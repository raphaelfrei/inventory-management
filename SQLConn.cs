using INVT;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public static class SQLConn {

    public static string ProgramPath = GetAppPath();
    public static readonly string DatabaseName = "invt.db";

    public static readonly string DatabasePath = Path.Combine(ProgramPath, DatabaseName);

    public static string IDUsuario = "";

    // Senha - Jet OLEDB:Database Password=NS3LtDwO$!3B;
    static string ConnectionString = $"Data Source={DatabasePath};";

    public static string usr_name = "";
    public static int usr_access = 0;

    private static string GetAppPath() {

        string path;

        //path = Application.StartupPath;

        path = File.ReadLines($"{Application.StartupPath}\\settings.ini").Skip(2).First();

        if (path == "" || path == null || !Directory.Exists(path))
            path = Application.StartupPath;

        return path;        

    }

    /*private static string GetProvider() {

        string provider;

         provider = "Microsoft.ACE.OLEDB.12.0";

        return provider; 

    provider = File.ReadLines($"{Application.StartupPath}\\settings.ini").Skip(4).First();

        if (string.IsNullOrWhiteSpace(provider)) {

            string message = "No provider was configured. Please insert one of this list:\n";

            var reader = OleDbEnumerator.GetRootEnumerator();

            while (reader.Read()) {
                for (var i = 0; i < reader.FieldCount; i++) {
                    if (reader.GetName(i) == "SOURCES_NAME") {
                        message += $"{reader.GetValue(i).ToString()}\n";
                    }
                }
                //Console.WriteLine("{0} = {1}", reader.GetName(0), reader.GetValue(0));
            }
            reader.Close();

            MessageBox.Show(message, "Status");

            provider = "Microsoft.ACE.OLEDB.12.0";

        }

        return provider;

    }*/

    public static bool CopyFile(string oldPath, string newPath) {

        try {

            File.Copy(oldPath, Path.Combine(ProgramPath, newPath));
            return true;

        } catch(Exception) {
            return false;
        }

    }

    public static long RunSQLCount(string command) {

        long count = 0;

        try {

            using (SqliteConnection conn = new SqliteConnection(ConnectionString)) {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand(command, conn)) {

                    count = (long)cmd.ExecuteScalar();

                }

            }

        } catch (Exception) {

        }

        return count;

    }

    public static void RunSQLCommand(string command) {

        try {

            using (SqliteConnection conn = new SqliteConnection(ConnectionString)) {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand(command, conn)) {

                    cmd.ExecuteNonQuery();

                }

            }

        } catch (Exception ex) {
            MessageBox.Show(ex.ToString());
        }

        return;

    }

    public static (bool status, string message) AddItem(Inbound item) {

        try {

            string selectCommand = $"SELECT COUNT(*) FROM EventoEntrada WHERE NumeroNF=@NumeroNF";
            string insertCommand = $"INSERT INTO EventoEntrada (Descricao, NumeroNF, DataEntrega, CNPJFornecedor, ValorNF, IDUsuario, ArquivoNF) VALUES (@Descricao, @NumeroNF, @DataEntrega, @CNPJFornecedor, @ValorNF, @IDUsuario, @ArquivoNF)";

            using (SqliteConnection conn = new SqliteConnection(ConnectionString)) {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand(selectCommand, conn)) {

                    cmd.Parameters.AddWithValue("@NumeroNF", item.NumeroNF);

                    long count = (long)cmd.ExecuteScalar();

                    if (count > 0) 
                        return(false, "Essa nota fiscal já foi cadastrada no sistema.");

                    using (SqliteCommand cmdd = new SqliteCommand(insertCommand, conn)) {
                        cmdd.Parameters.AddWithValue("@Descricao", item.Description);
                        cmdd.Parameters.AddWithValue("@NumeroNF", item.NumeroNF);
                        cmdd.Parameters.AddWithValue("@DataEntrega", item.DataEntrega.ToShortDateString());
                        cmdd.Parameters.AddWithValue("@CNPJFornecedor", item.CNPJFornecedor);
                        cmdd.Parameters.AddWithValue("@ValorNF", item.ValorNF);
                        cmdd.Parameters.AddWithValue("@IDUsuario", item.IDUsuario);
                        cmdd.Parameters.AddWithValue("@ArquivoNF", item.ArquivoNF);

                        cmdd.ExecuteNonQuery();

                    }

                    foreach (InboundItem subitem in item.Itens)
                        AddItem(subitem);

                    return (true, "Nota fiscal adicionada ao sistema.");

                }

            }

        } catch (Exception ex){
            return (false, $"Ocorreu um erro. \n{ex}");
        }
        
    }

    public static long GetIntValue(string command) {

        long value = 0;

        try {

            using (SqliteConnection conn = new SqliteConnection(ConnectionString)) {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand(command, conn)) {

                    value = (long)cmd.ExecuteScalar();

                }

            }

        } catch (Exception) {

        }

        return value;

    }

    public static DataTable GetTable(string selectCommand) {
        DataTable dt = new DataTable();

        try {
            using (SqliteConnection conn = new SqliteConnection(ConnectionString)) {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand(selectCommand, conn)) {
                    using (SqliteDataReader reader = cmd.ExecuteReader()) {
                        dt.Load(reader);
                    }
                }
            }
        } catch (Exception ex) {
            MessageBox.Show(ex.ToString());
        }

        return dt;
    }

    public static void AddItem(InboundItem item) {

        try {

            string selectCommand = $"SELECT COUNT(*) FROM ItemNF WHERE NumeroNF=@NumeroNF AND CodigoProduto=@CodigoProduto";
            string insertCommand = $"INSERT INTO ItemNF (NumeroNF, CodigoProduto, Quantidade) VALUES (@NumeroNF, @CodigoProduto, @Quantidade)";

            using (SqliteConnection conn = new SqliteConnection(ConnectionString)) {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand(selectCommand, conn)) {

                    cmd.Parameters.AddWithValue("@NumeroNF", item.NumeroNF);
                    cmd.Parameters.AddWithValue("@CodigoProduto", item.CodigoProduto);

                    long count = (long)cmd.ExecuteScalar();

                    if (count > 0)
                        return;

                    using (SqliteCommand cmdd = new SqliteCommand(insertCommand, conn)) {

                        cmdd.Parameters.AddWithValue("@NumeroNF", item.NumeroNF);
                        cmdd.Parameters.AddWithValue("@CodigoProduto", item.CodigoProduto);
                        cmdd.Parameters.AddWithValue("@Quantidade", item.QuantidadeProduto);

                        cmdd.ExecuteNonQuery();

                    }

                    string updateCommand = $"UPDATE Produto SET Estoque = Estoque + @Quantidade WHERE CodigoProduto=@CodigoProduto";

                    using (SqliteCommand cmdd = new SqliteCommand(updateCommand, conn)) {

                        cmdd.Parameters.AddWithValue("@Quantidade", item.QuantidadeProduto);
                        cmdd.Parameters.AddWithValue("@CodigoProduto", item.CodigoProduto);

                        cmdd.ExecuteNonQuery();

                    }

                }

            }

        } catch (Exception) {

        }

    }

}
