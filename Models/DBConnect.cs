using MySql.Data.MySqlClient;
namespace G6API.Models
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;// = "dfkpczjgmpvkugnb.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
        private string database; //
        private string port; //
        private string user; //
        private string password; //  
        public DBConnect(){
            Initialize();
        }
        private void Initialize(){
            server = "ckshdphy86qnz0bj.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            user = "xycx53dafpg9b10t";
            database = "owcnqeqjzs8b90tq";
            port = "3306";
            password = "f1q216833zamufh0";
            string cs = $@"server = {server};user={user};database={database};port={port};password={password};";
            connection = new MySqlConnection(cs);
        }
        public bool OpenConnection(){
            try{
                connection.Open();
                return true;
            }catch(MySqlException ex){
                if(ex.Number == 0){
                    System.Console.WriteLine(ex.Message);
                    System.Console.WriteLine("cannot connect");
                }else{
                    if(ex.Number == 1045){
                        System.Console.WriteLine("invalid username/password");
                    }
                }
            }
            return false;
        }
        public bool CloseConnection(){
            try{
                connection.Close();
                return true;
            }catch(MySqlException ex){
                System.Console.WriteLine(ex.Message);
            }
            return false;
        }

        public MySqlConnection GetConn(){
            return connection;
        }

    }
}