namespace ERPCmdtApi.ViewModelsAppro
{
    public class AppelOffreVm
    {
        public string? NoAppelOffre { get; set; }

        public string? ReferenceDC { get; set; }

        public string? Objet { get; set; }

        public DateTime? DatePublication { get; set; }

        public DateTime? DateAttribution { get; set; }

        public int? NoAttribMarche { get; set; }

        public string? Origine { get; set; }

        public Guid IdCampagne { get; set; }

        public string? LibelleCampagne { get; set; }
    }
}
