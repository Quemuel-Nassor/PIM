using PIM.Controllers.Database;
using PIM.Controllers.Utils;
using System;
using System.Collections.Generic;

namespace PIM.Models.Positions
{
    public class PositionController
    {
        public void Create(Position input)
        {
            try
            {
                string sqlArgs = MapperHelper.MapToInsertDb(input);
                DatabaseController.ExecuteQuery($"INSERT INTO Holerite_Pim.Cargo {sqlArgs}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PositionController | Create | error: {e.Message}");
            }
        }

        public void Update(Position input)
        {
            try
            {
                string sqlArgs = MapperHelper.MapToUpdateDb(input);
                DatabaseController.ExecuteQuery($"UPDATE Holerite_Pim.Cargo {sqlArgs}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PositionController | Update | error: {e.Message}");
            }
        }

        public void Delete(ulong id)
        {
            try
            {
                DatabaseController.ExecuteQuery($"DELETE FROM Holerite_Pim.Cargo WHERE Id={id}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PositionController | Delete | error: {e.Message}");
            }
        }

        public Position Get(ulong id)
        {
            Position cargo = null;
            try
            {
                var result = DatabaseController.ExecuteQuery($"SELECT * FROM Holerite_Pim.Cargo WHERE Id={id}");
                result.Read();

                cargo = MapperHelper.MapFromDb<Position>(result);
                result.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PositionController | Get | error: {e.Message}");
            }

            return cargo;
        }

        public List<Position> Get()
        {
            List<Position> cargos = new List<Position>();
            try
            {
                var result = DatabaseController.ExecuteQuery($"SELECT * FROM Holerite_Pim.Cargo");

                while (result.Read())
                {
                    cargos.Add(MapperHelper.MapFromDb<Position>(result));
                }
                result.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PositionController | Get | error: {e.Message}");
            }

            return cargos;
        }
    }
}
