using PIM.Controllers.Database;
using PIM.Controllers.Utils;
using PIM.Models.Permissions;
using PIM.Models.Employees;
using System;
using System.Collections.Generic;

namespace PIM.Controllers.Employees
{
    public class EmployeeController
    {
        public void Create(Employee input)
        {
            try
            {
                string sqlArgs = MapperHelper.MapToInsertDb(input);
                DatabaseController.ExecuteQuery($"INSERT INTO Holerite_Pim.Funcionario {sqlArgs}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"EmployeeController | Create | error: {e.Message}");
            }
        }

        public void Update(Employee input)
        {
            try
            {
                string sqlArgs = MapperHelper.MapToUpdateDb(input);
                DatabaseController.ExecuteQuery($"UPDATE Holerite_Pim.Funcionario {sqlArgs}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"EmployeeController | Update | error: {e.Message}");
            }
        }

        public void Delete(ulong id)
        {
            try
            {
                DatabaseController.ExecuteQuery($"DELETE FROM Holerite_Pim.Funcionario WHERE Id={id}").Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"EmployeeController | Delete | error: {e.Message}");
            }
        }

        public Employee Get(ulong id)
        {
            Employee Funcionario = null;
            try
            {
                var result = DatabaseController.ExecuteQuery($"SELECT * FROM Holerite_Pim.Funcionario WHERE Id={id}");
                result.Read();

                Funcionario = MapperHelper.MapFromDb<Employee>(result);
                result.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"EmployeeController | Get | error: {e.Message}");
            }

            return Funcionario;
        }

        public List<Employee> Get()
        {
            List<Employee> Funcionarios = new List<Employee>();
            try
            {
                var result = DatabaseController.ExecuteQuery($"SELECT * FROM Holerite_Pim.Funcionario");

                while (result.Read())
                {
                    Funcionarios.Add(MapperHelper.MapFromDb<Employee>(result));
                }
                result.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"EmployeeController | Get | error: {e.Message}");
            }

            return Funcionarios;
        }

        public Employee Get(string email)
        {
            Employee Funcionario = null;
            try
            {
                var result = DatabaseController.ExecuteQuery($"SELECT * FROM Holerite_Pim.Funcionario WHERE Id={id}");
                result.Read();

                Funcionario = MapperHelper.MapFromDb<Employee>(result);
                result.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"EmployeeController | Get | error: {e.Message}");
            }

            return Funcionario;
        }
    }
}
