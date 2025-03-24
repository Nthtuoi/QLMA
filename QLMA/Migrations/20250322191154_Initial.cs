using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLMA.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID_AD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.ID_AD);
                });

            migrationBuilder.CreateTable(
                name: "BaoCaoThongKes",
                columns: table => new
                {
                    ID_BaoCao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBaoCao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoaiBaoCao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoCaoThongKes", x => x.ID_BaoCao);
                });

            migrationBuilder.CreateTable(
                name: "DiemPhatThucPhams",
                columns: table => new
                {
                    ID_DPTT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDiem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_ToChucTuThien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemPhatThucPhams", x => x.ID_DPTT);
                });

            migrationBuilder.CreateTable(
                name: "NguoiCanHoTros",
                columns: table => new
                {
                    ID_NCHT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiCanHoTros", x => x.ID_NCHT);
                });

            migrationBuilder.CreateTable(
                name: "NhaHaoTams",
                columns: table => new
                {
                    ID_NHT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaHaoTams", x => x.ID_NHT);
                });

            migrationBuilder.CreateTable(
                name: "NhaTuyenDungs",
                columns: table => new
                {
                    ID_NTD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaTuyenDungs", x => x.ID_NTD);
                });

            migrationBuilder.CreateTable(
                name: "NoiOs",
                columns: table => new
                {
                    ID_NoiO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNoiO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sogiuongcosan = table.Column<int>(type: "int", nullable: false),
                    Lienhe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoiOs", x => x.ID_NoiO);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDangKies",
                columns: table => new
                {
                    ID_PDK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiDangKy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_NguoiDangKy = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_NoiO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDangKies", x => x.ID_PDK);
                });

            migrationBuilder.CreateTable(
                name: "QuyenGops",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_NhaHaoTam = table.Column<int>(type: "int", nullable: false),
                    ID_ToChucTuThien = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<float>(type: "real", nullable: false),
                    LoaiQG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayGop = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyenGops", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ToChucTuThiens",
                columns: table => new
                {
                    ID_TCTT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenToChuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Loaihinhhotro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToChucTuThiens", x => x.ID_TCTT);
                });

            migrationBuilder.CreateTable(
                name: "QuanLys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Admin = table.Column<int>(type: "int", nullable: false),
                    TenBang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Bang = table.Column<int>(type: "int", nullable: false),
                    LoaiHanhDong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayThucHien = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanLys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QuanLys_Admins_ID_Admin",
                        column: x => x.ID_Admin,
                        principalTable: "Admins",
                        principalColumn: "ID_AD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDKVLs",
                columns: table => new
                {
                    ID_PDKVL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayUngTuyen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_NguoiDangKy = table.Column<int>(type: "int", nullable: false),
                    NguoiDangKyID_NCHT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDKVLs", x => x.ID_PDKVL);
                    table.ForeignKey(
                        name: "FK_PhieuDKVLs_NguoiCanHoTros_NguoiDangKyID_NCHT",
                        column: x => x.NguoiDangKyID_NCHT,
                        principalTable: "NguoiCanHoTros",
                        principalColumn: "ID_NCHT");
                });

            migrationBuilder.CreateTable(
                name: "ViecLams",
                columns: table => new
                {
                    ID_VL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucLuong = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Yeucaukynang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_NhaTuyenDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViecLams", x => x.ID_VL);
                    table.ForeignKey(
                        name: "FK_ViecLams_NhaTuyenDungs_ID_NhaTuyenDung",
                        column: x => x.ID_NhaTuyenDung,
                        principalTable: "NhaTuyenDungs",
                        principalColumn: "ID_NTD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QLDPTTs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DPTT = table.Column<int>(type: "int", nullable: false),
                    ID_TCTT = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QLDPTTs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QLDPTTs_DiemPhatThucPhams_ID_DPTT",
                        column: x => x.ID_DPTT,
                        principalTable: "DiemPhatThucPhams",
                        principalColumn: "ID_DPTT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QLDPTTs_ToChucTuThiens_ID_TCTT",
                        column: x => x.ID_TCTT,
                        principalTable: "ToChucTuThiens",
                        principalColumn: "ID_TCTT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TinhNguyenViens",
                columns: table => new
                {
                    ID_TNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_ToChucTuThien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhNguyenViens", x => x.ID_TNV);
                    table.ForeignKey(
                        name: "FK_TinhNguyenViens_ToChucTuThiens_ID_ToChucTuThien",
                        column: x => x.ID_ToChucTuThien,
                        principalTable: "ToChucTuThiens",
                        principalColumn: "ID_TCTT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDKVLs_NguoiDangKyID_NCHT",
                table: "PhieuDKVLs",
                column: "NguoiDangKyID_NCHT");

            migrationBuilder.CreateIndex(
                name: "IX_QLDPTTs_ID_DPTT",
                table: "QLDPTTs",
                column: "ID_DPTT");

            migrationBuilder.CreateIndex(
                name: "IX_QLDPTTs_ID_TCTT",
                table: "QLDPTTs",
                column: "ID_TCTT");

            migrationBuilder.CreateIndex(
                name: "IX_QuanLys_ID_Admin",
                table: "QuanLys",
                column: "ID_Admin");

            migrationBuilder.CreateIndex(
                name: "IX_TinhNguyenViens_ID_ToChucTuThien",
                table: "TinhNguyenViens",
                column: "ID_ToChucTuThien");

            migrationBuilder.CreateIndex(
                name: "IX_ViecLams_ID_NhaTuyenDung",
                table: "ViecLams",
                column: "ID_NhaTuyenDung");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaoCaoThongKes");

            migrationBuilder.DropTable(
                name: "NhaHaoTams");

            migrationBuilder.DropTable(
                name: "NoiOs");

            migrationBuilder.DropTable(
                name: "PhieuDangKies");

            migrationBuilder.DropTable(
                name: "PhieuDKVLs");

            migrationBuilder.DropTable(
                name: "QLDPTTs");

            migrationBuilder.DropTable(
                name: "QuanLys");

            migrationBuilder.DropTable(
                name: "QuyenGops");

            migrationBuilder.DropTable(
                name: "TinhNguyenViens");

            migrationBuilder.DropTable(
                name: "ViecLams");

            migrationBuilder.DropTable(
                name: "NguoiCanHoTros");

            migrationBuilder.DropTable(
                name: "DiemPhatThucPhams");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "ToChucTuThiens");

            migrationBuilder.DropTable(
                name: "NhaTuyenDungs");
        }
    }
}
