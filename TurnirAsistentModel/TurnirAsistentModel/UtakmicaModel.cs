using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class UtakmicaModel
    {
        /// <summary>
        /// Popis natjecatelja koji igraju utakmicu
        /// </summary>
        public List<SudionikModel> Natjecatelj { get; set; } = new List<SudionikModel>();
        /// <summary>
        /// Broj rundi koji je odigran između 2 tima
        /// </summary>
        public int BrojRunde  { get; set; }
        /// <summary>
        /// Osoba/ Team koji je imo veći broj bodova
        /// </summary>
        public EkipaModel Pobjednik { get; set; } = new EkipaModel();
    }
}
