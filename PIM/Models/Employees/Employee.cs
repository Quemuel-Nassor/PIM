using PIM.Models.Permissions;
using PIM.Models.Positions;
using System;

namespace PIM.Models.Employees
{
    public class Employee
    {
        public ulong Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public ulong IdCargo { get; set; }
        public ulong IdPermissao { get; set; }
    }
}
