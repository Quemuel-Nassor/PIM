using PIM.Controllers.Database;
using PIM.Controllers.Utils;
using PIM.Models.Permissions;
using System.Collections.Generic;
using System;

namespace PIM.Models.Permissions
{
    public class PermissionController
    {
        public void Create(Permission input)
        {
            try
            {
                string sqlArgs = MapperHelper.MapToInsertDb(input);
                DatabaseController.ExecuteQuery($"INSERT INTO Holerite_Pim.Permissao {sqlArgs}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PermissionController | Create | error: {e.Message}");
            }
        }

        public void Update(Permission input)
        {
            try
            {
                string sqlArgs = MapperHelper.MapToUpdateDb(input);
                DatabaseController.ExecuteQuery($"UPDATE Holerite_Pim.Permissao {sqlArgs}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PermissionController | Update | error: {e.Message}");
            }
        }

        public void Delete(ulong id)
        {
            try
            {
                DatabaseController.ExecuteQuery($"DELETE FROM Holerite_Pim.Permissao WHERE Id={id}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PermissionController | Delete | error: {e.Message}");
            }
        }

        public Permission Get(ulong id)
        {
            Permission Permissao = null;
            try
            {
                var result = DatabaseController.ExecuteQuery($"SELECT * FROM Holerite_Pim.Permissao WHERE Id={id}");
                result.Read();

                Permissao = MapperHelper.MapFromDb<Permission>(result);
                result.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PermissionController | Get | error: {e.Message}");
            }

            return Permissao;
        }

        public List<Permission> Get()
        {
            List<Permission> Permissaos = new List<Permission>();
            try
            {
                var result = DatabaseController.ExecuteQuery($"SELECT * FROM Holerite_Pim.Permissao");

                while (result.Read())
                {
                    Permissaos.Add(MapperHelper.MapFromDb<Permission>(result));
                }
                result.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"PermissionController | Get | error: {e.Message}");
            }

            return Permissaos;
        }
    }
}
