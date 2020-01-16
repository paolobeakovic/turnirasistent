using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    class NagradeModel
    {
        /// <summary>
        /// Mjesto koje je ekipa osvojila
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// Naziv mjesta npr 
        /// 1. mjesto : Champion 
        /// 2. mjesto : Lord ...
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Novac dobiven 
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// Dio nagrade koji je dobio tim za određeno mjesto na tablici
        /// </summary>
        public double PostotakNagrade { get; set; }
    }
}
