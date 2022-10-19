namespace MasterServicesFZ.Domain
{
    public class VehicleType
    {
        public int id { get; set; }
        public int? marca_clase_vehiculo_clase_id { get; set; }
        public string codigo_fasecolda { get; set; }
        public string tipo { get; set; }
        public bool activo { get; set; }
        public int? precio { get; set; }
    }
}
