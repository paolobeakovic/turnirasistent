using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class EkipaModel
    {
        /// <summary>
        /// Imena članova ekipe
        /// </summary>
        public List<OsobaModel> ClanoviEkipe { get; set; } = new List<OsobaModel>();
        /// <summary>
        /// Ime ekipe
        /// </summary>
        public string ImeEkipe { get; set; }
    }
}
