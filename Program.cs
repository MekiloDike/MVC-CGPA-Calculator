using Microsoft.EntityFrameworkCore;
using MVC_CGPA.DbContex;
using MVC_CGPA.Repository.Implementation;
using MVC_CGPA.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Register your DbContext with SQL Server
//builder.Services.AddDbContext<CgpaDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("CgpaDbConnection")));


//Register interface
builder.Services.AddScoped<ICgpa, Cgpa>();



var app = builder.Build();

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
