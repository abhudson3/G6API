using G6API.Models;
using MySql.Data.MySqlClient;
namespace G6API.ControllerMethods
{
    public class ReadCarData
    {
        public List<Car> GetAllCars()//GET method
        {
            DBConnect db = new DBConnect();

            bool isOpen = db.OpenConnection();

            if(isOpen){
                MySqlConnection conn = db.GetConn();
                string stm = "SELECT * FROM cars";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                List<Car> allCars = new List<Car>();
                using (var rdr = cmd.ExecuteReader())
                {
                    while(rdr.Read()){
                        allCars.Add(new Car(){id = rdr.GetInt32(0), imageLink = rdr.GetString(1), make = rdr.GetString(2), model = rdr.GetString(3), vehicleType = rdr.GetString(4), motorKw = rdr.GetString(5), drivetrain = rdr.GetString(6), mpge = rdr.GetString(7), vehicleRange = rdr.GetString(8), chargeRateL2Dc = rdr.GetString(9), chargeRateMphL1L2Dc = rdr.GetString(10), batteryCapacity = rdr.GetString(11), seats = rdr.GetString(12), msrp = rdr.GetString(13) });
                    }
                }
                db.CloseConnection();
                return allCars;
            }else{
                db.CloseConnection();
                return new List<Car>();
            }

        }
    }
}