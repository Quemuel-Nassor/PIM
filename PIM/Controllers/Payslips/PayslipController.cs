using PIM.Controllers.Database;
using PIM.Controllers.Utils;
using PIM.Models.Payslips;
using System;
using System.Collections.Generic;

namespace PIM.Controllers.Payslips
{
    public class PayslipController
    {
        public void Create(Payslip input)
        {
            try
            {
                string sqlArgs = MapperHelper.MapToInsertDb(input);
                DatabaseController.ExecuteQuery($"INSERT INTO Holerite_Pim.Holerite {sqlArgs}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PayslipController | Create | error: {e.Message}");
            }
        }

        public void Update(Payslip input)
        {
            try
            {
                string sqlArgs = MapperHelper.MapToUpdateDb(input);
                DatabaseController.ExecuteQuery($"UPDATE Holerite_Pim.Holerite {sqlArgs}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PayslipController | Update | error: {e.Message}");
            }
        }

        public void Delete(ulong id)
        {
            try
            {
                DatabaseController.ExecuteQuery($"DELETE FROM Holerite_Pim.Holerite WHERE Id={id}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PayslipController | Delete | error: {e.Message}");
            }
        }

        public Payslip Get(ulong id)
        {
            Payslip Holerite = null;
            try
            {
                var result = DatabaseController.ExecuteQuery($"SELECT * FROM Holerite_Pim.Holerite WHERE Id={id}");
                result.Read();

                Holerite = MapperHelper.MapFromDb<Payslip>(result);
                result.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PayslipController | Get | error: {e.Message}");
            }

            return Holerite;
        }

        public List<Payslip> Get()
        {
            List<Payslip> Holerites = new List<Payslip>();
            try
            {
                var result = DatabaseController.ExecuteQuery($"SELECT * FROM Holerite_Pim.Holerite");

                while (result.Read())
                {
                    Holerites.Add(MapperHelper.MapFromDb<Payslip>(result));
                }
                result.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PayslipController | Get | error: {e.Message}");
            }

            return Holerites;
        }
    }
}
