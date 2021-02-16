using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFood.Model
{
    public class Aliquotas
    {
        public int Id { get; set; }
        public decimal PercentualPis { get; set; }
        public decimal CstpPis { get; set; }
        public decimal Cfop { get; set; }
        public decimal CstConfins { get; set; }
        public decimal PrecentualConfins { get; set; }
        public decimal AliquotaCSOSN { get; set; }
        public decimal Csosn { get; set; }
        public decimal Cest { get; set; }
        public decimal AliquotaICMS { get; set; }
        public decimal AliquotaFederal { get; set; }
        public decimal AliquotaEstadual { get; set; }
        public decimal AliquotaMunicipal { get; set; }
        public SituacaoTributaria SituacaoTributaria { get; set; }
    }
}
