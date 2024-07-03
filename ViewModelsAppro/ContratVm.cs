namespace ERPCmdtApi.ViewModelsAppro
{
    public class ContratVm
    {
        public int? NoContrat { get; set; }

        public int? NoAvenant { get; set; }

        public DateTime DateContrat { get; set; }

        public int? NoLettreNotification { get; set; }

        public DateTime? DateLettreNotification { get; set; }

        public DateTime DateFirstLivraison { get; set; }

        public DateTime DateLastLivraison { get; set; }

        public bool? IsContratAnnexe { get; set; }

        public bool? IsAnnule { get; set; }

        public DateTime? DateAnnulation { get; set; }

        public string? Origine { get; set; }

        public string? NoCommande { get; set; }

        public decimal Montant { get; set; }

        public Guid IdAppelOffres { get; set; }

        public string? NoAppelOffre { get; set; }
    }
}
