using api.Models;
using MySql.Data.MySqlClient; 
namespace G6API.ControllerMethods
{
    public class EditCarData
    {
        public void AddCar(Car value)//POST method
        {
            DBConnect db = new DBConnect();

            bool isOpen = db.OpenConnection();

            if(isOpen){
                MySqlConnection conn = db.GetConn();
                string stm = @"INSERT INTO cars (imageLink, make, model, vehicleType, motorKw, drivetrain, mpge, vehicleRange, chargeRateL2Dc, chargeRateMphL1L2Dc, batteryCapacity, seats, msrp)
                            VALUES (@imageLink, @make, @model, @vehicleType, @motorKw, @drivetrain, @mpge, @vehicleRange, @chargeRateL2Dc, @chargeRateMphL1L2Dc, @batteryCapacity, @seats, @msrp);";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                //cmd.CommandText = stm;
                cmd.Parameters.AddWithValue("@imageLink", value.title);
                cmd.Parameters.AddWithValue("@make", value.artist);
                cmd.Parameters.AddWithValue("@model", value.dateAdded);
                cmd.Parameters.AddWithValue("@vehicleType", value.favorited);
                cmd.Parameters.AddWithValue("@motorKw", value.deleted);
                cmd.Parameters.AddWithValue("@driveTrain", value.deleted);
                cmd.Parameters.AddWithValue("@mpge", value.deleted);
                cmd.Parameters.AddWithValue("@vehicleRange", value.deleted);
                cmd.Parameters.AddWithValue("@chargeRateL2Dc", value.deleted);
                cmd.Parameters.AddWithValue("@chargeRateMphL1L2Dc", value.deleted);
                cmd.Parameters.AddWithValue("@batteryCapacity", value.deleted);
                cmd.Parameters.AddWithValue("@seats", value.deleted);
                cmd.Parameters.AddWithValue("@msrp", value.deleted);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                
            }else{
                db.CloseConnection();
                //lmao you should add an error message here
            }
        }
        public void EditCar(int id, Car value){//PUT method
            DBConnect db = new DBConnect();

            bool isOpen = db.OpenConnection();

            if(isOpen){
                MySqlConnection conn = db.GetConn();
                string stm = @"UPDATE songs set imageLink = @imageLink, make = @make, model = @model, vehicleType = @vehicleType, motorKw = @motorKw, drivetrain = @drivetrain, mpge = @mpge, vehicleRange = @vehicleRange, chargeRateL2Dc = @chargeRateL2Dc, chargeRateMphL1L2Dc = @chargeRateMphL1L2Dc, batteryCapacity = @batteryCapacity, seats = @seats, msrp = @msrp WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Parameters.AddWithValue("@imageLink", value.title);
                cmd.Parameters.AddWithValue("@make", value.artist);
                cmd.Parameters.AddWithValue("@model", value.dateAdded);
                cmd.Parameters.AddWithValue("@vehicleType", value.favorited);
                cmd.Parameters.AddWithValue("@motorKw", value.deleted);
                cmd.Parameters.AddWithValue("@driveTrain", value.deleted);
                cmd.Parameters.AddWithValue("@mpge", value.deleted);
                cmd.Parameters.AddWithValue("@vehicleRange", value.deleted);
                cmd.Parameters.AddWithValue("@chargeRateL2Dc", value.deleted);
                cmd.Parameters.AddWithValue("@chargeRateMphL1L2Dc", value.deleted);
                cmd.Parameters.AddWithValue("@batteryCapacity", value.deleted);
                cmd.Parameters.AddWithValue("@seats", value.deleted);
                cmd.Parameters.AddWithValue("@msrp", value.deleted);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                
            }else{
                db.CloseConnection();
                //lmao you should add an error message here
            }
        }
    }
}