namespace ERPCmdtApi.ViewModelsAppro
{
    public class CampagneVm
    {
        public Guid Id { get; set; }
        public string? Libelle { get; set; }

        public string? Abrege { get; set; }

        public DateTime? Debut { get; set; }

        public DateTime? Fin { get; set; }
    }
}
