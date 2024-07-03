using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aApprosDbContext.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campagnes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Abrege = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Debut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campagnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cdtnts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Abrege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cdtnts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Abrege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseurs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RaisonSociale = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Sigle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RepresentantTitre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepresentantNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone1 = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Telephone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RCCM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIF = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Abrege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UniteAchats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Abrege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniteAchats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppelOffres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoAppelOffre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceDC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Objet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePublication = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateAttribution = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoAttribMarche = table.Column<int>(type: "int", maxLength: 256, nullable: false),
                    Origine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampagneId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppelOffres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppelOffres_Campagnes_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagnes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Affectations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Abrege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    DirectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affectations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Affectations_Directions_DirectionId",
                        column: x => x.DirectionId,
                        principalTable: "Directions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abrege = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LibCommercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacite = table.Column<decimal>(type: "decimal(18,2)", maxLength: 256, nullable: false),
                    CdtntId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UniteAchatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produits_Cdtnts_CdtntId",
                        column: x => x.CdtntId,
                        principalTable: "Cdtnts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produits_UniteAchats_UniteAchatId",
                        column: x => x.UniteAchatId,
                        principalTable: "UniteAchats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contrats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoContrat = table.Column<int>(type: "int", maxLength: 256, nullable: false),
                    NoAvenant = table.Column<int>(type: "int", nullable: true),
                    DateContrat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoLettreNotification = table.Column<int>(type: "int", nullable: true),
                    DateLettreNotification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateFirstLivraison = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastLivraison = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsContratAnnexe = table.Column<bool>(type: "bit", nullable: true),
                    IsAnnule = table.Column<bool>(type: "bit", nullable: true),
                    DateAnnulation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Origine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoCommande = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AppelOffreId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FournisseurId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contrats_AppelOffres_AppelOffreId",
                        column: x => x.AppelOffreId,
                        principalTable: "AppelOffres",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contrats_Fournisseurs_FournisseurId",
                        column: x => x.FournisseurId,
                        principalTable: "Fournisseurs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contrats_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContratDts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrixUnitaire = table.Column<long>(type: "bigint", nullable: false),
                    Qte = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QteResilie = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContratIntrantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AffectationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratDts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratDts_Affectations_AffectationId",
                        column: x => x.AffectationId,
                        principalTable: "Affectations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContratDts_Contrats_ContratIntrantId",
                        column: x => x.ContratIntrantId,
                        principalTable: "Contrats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContratDts_Produits_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Receptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoReception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoFactureFour = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NoPiece = table.Column<int>(type: "int", nullable: true),
                    NoBordereau = table.Column<int>(type: "int", nullable: true),
                    DateReception = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTransComptabilite = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContratDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receptions_ContratDts_ContratDtId",
                        column: x => x.ContratDtId,
                        principalTable: "ContratDts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReceptionDts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QteDeclare = table.Column<int>(type: "int", nullable: true),
                    QteRe = table.Column<int>(type: "int", nullable: false),
                    PrixUnitaire = table.Column<long>(type: "bigint", nullable: false),
                    Montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionDts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceptionDts_Receptions_ReceptionId",
                        column: x => x.ReceptionId,
                        principalTable: "Receptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Affectations_DirectionId",
                table: "Affectations",
                column: "DirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppelOffres_CampagneId",
                table: "AppelOffres",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratDts_AffectationId",
                table: "ContratDts",
                column: "AffectationId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratDts_ContratIntrantId",
                table: "ContratDts",
                column: "ContratIntrantId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratDts_ProduitId",
                table: "ContratDts",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_AppelOffreId",
                table: "Contrats",
                column: "AppelOffreId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_FournisseurId",
                table: "Contrats",
                column: "FournisseurId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_StatusId",
                table: "Contrats",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CdtntId",
                table: "Produits",
                column: "CdtntId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_UniteAchatId",
                table: "Produits",
                column: "UniteAchatId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionDts_ReceptionId",
                table: "ReceptionDts",
                column: "ReceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Receptions_ContratDtId",
                table: "Receptions",
                column: "ContratDtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceptionDts");

            migrationBuilder.DropTable(
                name: "Receptions");

            migrationBuilder.DropTable(
                name: "ContratDts");

            migrationBuilder.DropTable(
                name: "Affectations");

            migrationBuilder.DropTable(
                name: "Contrats");

            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "Directions");

            migrationBuilder.DropTable(
                name: "AppelOffres");

            migrationBuilder.DropTable(
                name: "Fournisseurs");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Cdtnts");

            migrationBuilder.DropTable(
                name: "UniteAchats");

            migrationBuilder.DropTable(
                name: "Campagnes");
        }
    }
}
