using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class OsobaModel
    {
        /// <summary>
        /// Ime igrača , npr Paolo
        /// </summary>
        public string iIme { get; set; }
        /// <summary>
        /// Prezime igrača , npr Beakovic
        /// </summary>
        public string Prezime { get; set; }
        /// <summary>
        /// Email adresa igrača na kojem mu šaljemo 
        /// obavjesti vezano za turnir
        /// </summary>
        public string Emailadresa { get; set; }
        /// <summary>
        /// BrojMobitelja adresa igrača na kojem mu šaljemo 
        /// obavjesti vezano za turnir
        /// </summary>
        public string BrojMobitela { get; set; }
    }


}
