using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using QLMA.Models;
using QLMA.Repository;
var builder = WebApplication.CreateBuilder(args);

// Thêm DbContext vào dịch vụ
builder.Services.AddDbContext<QLMAContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<ADMIN, IdentityRole>()
     .AddEntityFrameworkStores<QLMAContext>()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IAdminRepository, EFAdminRepository>();
builder.Services.AddScoped<IBaoCaoThongKeRepository, EFBaoCaoThongKeRepository>();
builder.Services.AddScoped<IDiemPhatThucPhamRepository, EFDiemPhatThucPhamRepository>();
builder.Services.AddScoped<INguoiCanHoTroRepository, EFNguoiCanHoTroRepository>();
builder.Services.AddScoped<INhaHaoTamRepository, EFNhaHaoTamRepository>();
builder.Services.AddScoped<INhaTuyenDungRepository, EFNhaTuyenDungRepository>();
builder.Services.AddScoped<INoiORepository, EFNoiORepository>();
builder.Services.AddScoped<IPhieuDangKyRepository, EFPhieuDangKyRepository>();
builder.Services.AddScoped<IPDKVLRepository, EFPhieuDKVLRepository>();
builder.Services.AddScoped<IQLDPTPRepository, EFQLDPTPRepository>();
builder.Services.AddScoped<IQuanLyRepository, EFQuanLyRepository>();
builder.Services.AddScoped<IQuyenGopRepository, EFQuyenGopRepository>();
builder.Services.AddScoped<ITinhNguyenVienRepository, EFTinhNguyenVienRepository>();
builder.Services.AddScoped<IToChucTuThienRepository, EFToChucTuThienRepository>();
builder.Services.AddScoped<IViecLamRepository, EFViecLamRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
