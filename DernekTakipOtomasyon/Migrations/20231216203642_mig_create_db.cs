using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DernekTakipOtomasyon.Migrations
{
    public partial class mig_create_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aylar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyAdi = table.Column<string>(nullable: true),
                    Tutar = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aylar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "iller",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sehir = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iller", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Uye",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TC = table.Column<string>(maxLength: 11, nullable: true),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    Sehir = table.Column<string>(nullable: true),
                    KanGrubu = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    Durum = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uye", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yetkili",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAd = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkili", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Aidat",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Miktar = table.Column<decimal>(maxLength: 11, nullable: false),
                    OdemeTarihi = table.Column<DateTime>(nullable: false),
                    Durum = table.Column<bool>(nullable: false),
                    UyeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aidat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Aidat_Uye_UyeID",
                        column: x => x.UyeID,
                        principalTable: "Uye",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Duyuru",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YetkiliAdi = table.Column<string>(nullable: true),
                    Baslik = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false),
                    YetkiliID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duyuru", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Duyuru_Yetkili_YetkiliID",
                        column: x => x.YetkiliID,
                        principalTable: "Yetkili",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aylar",
                columns: new[] { "ID", "AyAdi", "Tutar" },
                values: new object[,]
                {
                    { 1, "OCAK", 100m },
                    { 2, "ŞUBAT", 200m },
                    { 3, "MART", 300m },
                    { 4, "NİSAN", 400m },
                    { 5, "MAYIS", 500m },
                    { 6, "HAZİRAN", 600m },
                    { 7, "TEMMUZ", 700m },
                    { 8, "AĞUSTOS", 800m },
                    { 9, "EYLÜL", 900m },
                    { 10, "EKİM", 1000m },
                    { 11, "KASIM", 1100m },
                    { 12, "ARALIK", 1200m }
                });

            migrationBuilder.InsertData(
                table: "Yetkili",
                columns: new[] { "ID", "KullaniciAd", "Sifre" },
                values: new object[] { 1, "admin", "000" });

            migrationBuilder.CreateIndex(
                name: "IX_Aidat_UyeID",
                table: "Aidat",
                column: "UyeID");

            migrationBuilder.CreateIndex(
                name: "IX_Duyuru_YetkiliID",
                table: "Duyuru",
                column: "YetkiliID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aidat");

            migrationBuilder.DropTable(
                name: "Aylar");

            migrationBuilder.DropTable(
                name: "Duyuru");

            migrationBuilder.DropTable(
                name: "iller");

            migrationBuilder.DropTable(
                name: "Uye");

            migrationBuilder.DropTable(
                name: "Yetkili");
        }
    }
}
