using System;

namespace PIM.Models.Payslips
{
    public class Payslip
    {
        public ulong Id { get; set; }
        public DateTime CreationTime { get; set; }
        public decimal SalarioLiquido { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal Fgts { get; set; }
        public decimal Inss { get; set; }
        public decimal ValeTransporte { get; set; }
        public ulong IdFuncionario { get; set; }
    }
}
