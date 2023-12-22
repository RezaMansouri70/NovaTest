using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Model.Doping
{
    public class DopingModel
    {
        public string TeilnehmerName { get; set; }
        public string TeilnehmerVerband { get; set; }
        public float? TeilnehmerIstGewicht { get; set; }
    }
}
