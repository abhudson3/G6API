using G6API.Models;
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
                cmd.Parameters.AddWithValue("@imageLink", value.imageLink);
                cmd.Parameters.AddWithValue("@make", value.make);
                cmd.Parameters.AddWithValue("@model", value.model);
                cmd.Parameters.AddWithValue("@vehicleType", value.vehicleType);
                cmd.Parameters.AddWithValue("@motorKw", value.motorKw);
                cmd.Parameters.AddWithValue("@driveTrain", value.drivetrain);
                cmd.Parameters.AddWithValue("@mpge", value.mpge);
                cmd.Parameters.AddWithValue("@vehicleRange", value.vehicleRange);
                cmd.Parameters.AddWithValue("@chargeRateL2Dc", value.chargeRateL2Dc);
                cmd.Parameters.AddWithValue("@chargeRateMphL1L2Dc", value.chargeRateMphL1L2Dc);
                cmd.Parameters.AddWithValue("@batteryCapacity", value.batteryCapacity);
                cmd.Parameters.AddWithValue("@seats", value.seats);
                cmd.Parameters.AddWithValue("@msrp", value.msrp);
                
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
                string stm = @"UPDATE cars set imageLink = @imageLink, make = @make, model = @model, vehicleType = @vehicleType, motorKw = @motorKw, drivetrain = @drivetrain, mpge = @mpge, vehicleRange = @vehicleRange, chargeRateL2Dc = @chargeRateL2Dc, chargeRateMphL1L2Dc = @chargeRateMphL1L2Dc, batteryCapacity = @batteryCapacity, seats = @seats, msrp = @msrp WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Parameters.AddWithValue("@imageLink", value.imageLink);
                cmd.Parameters.AddWithValue("@make", value.make);
                cmd.Parameters.AddWithValue("@model", value.model);
                cmd.Parameters.AddWithValue("@vehicleType", value.vehicleType);
                cmd.Parameters.AddWithValue("@motorKw", value.motorKw);
                cmd.Parameters.AddWithValue("@driveTrain", value.drivetrain);
                cmd.Parameters.AddWithValue("@mpge", value.mpge);
                cmd.Parameters.AddWithValue("@vehicleRange", value.vehicleRange);
                cmd.Parameters.AddWithValue("@chargeRateL2Dc", value.chargeRateL2Dc);
                cmd.Parameters.AddWithValue("@chargeRateMphL1L2Dc", value.chargeRateMphL1L2Dc);
                cmd.Parameters.AddWithValue("@batteryCapacity", value.batteryCapacity);
                cmd.Parameters.AddWithValue("@seats", value.seats);
                cmd.Parameters.AddWithValue("@msrp", value.msrp);
                
                
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                
            }else{
                db.CloseConnection();
                //lmao you should add an error message here
            }
        }
    }
}