using InsureYouAI.Context;
using InsureYouAI.Entities;
using InsureYouAI.Models;
using InsureYouAI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Runtime.Intrinsics.X86;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();
//Program.cs'deki tanım olmasaydı, constructor'da UserManager<AppUser> yazsan bile sistem "AppUser nedir?" diye bilemezdi. Önce sisteme tanıtman, sonra kullanman gerekiyor.
//Serviste AppUser yazarak sistemi tanımlıyoruz,
//Controller’da AppUser yazarak bu tanımlanmış servisi kullanıyoruz.

builder.Services.AddSignalR();
builder.Services.AddHttpClient("openai", c =>
    {
        c.BaseAddress = new Uri("https://api.openai.com/");
    }
);
 //“Uygulamada openai adında hazır bir HttpClient olsun” demektir.

builder.Services.AddDbContext<InsureContext>();
builder.Services.AddIdentity<AppUser,IdentityRole>()
    .AddEntityFrameworkStores<InsureContext>()
    .AddDefaultTokenProviders();
//Identity servislerini projeye ekle (UserManager, SignInManager, RoleManager vb.) ve bunlar çalışırken benim kullanıcı sınıfım AppUser, rol sınıfım IdentityRole olsun.
//Identity sisteminin veritabanı işlemleri için Entity Framework Core kullanmasını sağlar
//Şifre sıfırlamada ve e-posta doğrulamada gerekli güvenlik kodlarını üretmek için gerekli token sağlayıcılarını ekle


builder.Services.AddScoped<AIService>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();



var app = builder.Build();

app.UseExceptionHandler("/Error/500"); /*Uygulamada beklenmeyen bir hata (exception) oluştuğunda devreye girer.*/
app.UseStatusCodePagesWithReExecute("/Error/{0}");

//Bu middleware HTTP status code’ları yakalar:
//404(sayfa bulunamadı)
//403(yasaklı)
//401(yetkisiz)
//500(server error olabilir ama genelde exception’dan farklıdır)
//ve bunları:
//👉 / Error /{ statusCode}
//sayfasına yönlendirir


app.MapHub<ChatHub>("/chathub");
//ChatHub adlı SignalR Hub’ını /chathub adresinden erişilebilir yapar.

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
