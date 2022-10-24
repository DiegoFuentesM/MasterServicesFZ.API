namespace MasterServicesFZ.Domain
{
    public class VehicleModel
    {
        public int id { get; set; }
        public bool activo{ get; set; }
        public int precio { get; set; }
        public int modelovehiculo_id { get; set; }
        public int tipovehiculo_id { get; set; }
        public int modelobienvehiculo_id { get; set; }
        public bool estado { get; set; }
    }
}
