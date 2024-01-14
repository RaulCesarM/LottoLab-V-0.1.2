using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LottoLab.Models
{
    public class LoteriaJson
    {
         public int Numero { get; set; }
        public string DataApuracao { get; set; }
        public List<int> DezenasSorteadasOrdemSorteio { get; set; }
    }
}