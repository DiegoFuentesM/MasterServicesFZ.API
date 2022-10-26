namespace MasterServicesFZ.Domain
{
    public class VehicleType
    {
        public int id { get; set; }
        public int? marca_vehiculo_clase_vehiculo_id { get; set; }
        public string codigo_fasecolda { get; set; }
        public string tipo { get; set; }
        public bool activo { get; set; }
        public int? precio { get; set; }
    }
}
