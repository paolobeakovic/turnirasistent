using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class TurnirModel
    {
        /// <summary>
        /// Naziv kojem će turnir imati
        /// </summary>
        public string NazivTurnira { get; set; }
        /// <summary>
        /// Novac koji timovi trebaju dat da se mogu prijaviti u turnir
        /// </summary>
        public decimal Kotizacija { get; set; }
        /// <summary>
        /// Broj i imena prijavljenih timova
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; }
        /// <summary>
        /// Nagrade koje osvajaju timovi , zavisi na kojem su mjestu
        /// </summary>
        public List<NagradeModel> Nagrade { get; set; } = new List<NagradeModel>();
        /// <summary>
        /// Broj zadanih rundi
        /// </summary>
        public List<List<Utakmica>> Runde { get; set; } = new List<List<Utakmica>>();

    }
}
