using Microsoft.EntityFrameworkCore;
using WebApplication11CRUD.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("CompanyDB");//�������� ������ ����������� � DB �� ����� ������������ appsettings.json
builder.Services.AddDbContextPool<CompanyDbContext>(option => option.UseSqlServer(connectionString));//��������� ������ "CompanyDbContext" � ��������� ��������
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");//�������� ���������� �� ��������� - "Employee"

app.Run();
