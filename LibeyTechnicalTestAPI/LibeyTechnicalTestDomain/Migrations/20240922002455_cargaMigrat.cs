using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibeyTechnicalTestDomain.Migrations
{
    /// <inheritdoc />
    public partial class cargaMigrat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.DocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionCode);
                });

            migrationBuilder.CreateTable(
                name: "Ubigeo",
                columns: table => new
                {
                    UbigeoCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProvinceCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegionCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UbigeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubigeo", x => x.UbigeoCode);
                    table.ForeignKey(
                        name: "FK_Ubigeo_Province_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Province",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ubigeo_Region_RegionCode",
                        column: x => x.RegionCode,
                        principalTable: "Region",
                        principalColumn: "RegionCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibeyUser",
                columns: table => new
                {
                    DocumentNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MothersLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UbigeoCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibeyUser", x => x.DocumentNumber);
                    table.ForeignKey(
                        name: "FK_LibeyUser_DocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibeyUser_Ubigeo_UbigeoCode",
                        column: x => x.UbigeoCode,
                        principalTable: "Ubigeo",
                        principalColumn: "UbigeoCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibeyUser_DocumentTypeId",
                table: "LibeyUser",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LibeyUser_UbigeoCode",
                table: "LibeyUser",
                column: "UbigeoCode");

            migrationBuilder.CreateIndex(
                name: "IX_Ubigeo_ProvinceCode",
                table: "Ubigeo",
                column: "ProvinceCode");

            migrationBuilder.CreateIndex(
                name: "IX_Ubigeo_RegionCode",
                table: "Ubigeo",
                column: "RegionCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibeyUser");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "Ubigeo");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Region");
        }
    }
}
