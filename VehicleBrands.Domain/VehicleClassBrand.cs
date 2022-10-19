using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterServicesFZ.Domain
{
    public class VehicleClassBrand
    {
        public int id { get; set; }
        public string marca_vehiculo_id { get; set; }
        public string clase_vehiculo_id { get; set; }
        public bool activo{ get; set; }
        public string clasevehiculo { get; set; }
        public bool? llavecompuestaestaxi { get; set; }
        public bool? escamion { get; set; }
        public bool? esmoto { get; set; }
    }
}
