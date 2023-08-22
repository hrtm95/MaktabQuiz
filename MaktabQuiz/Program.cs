using MaktabQuiz.Models.Database;
using MaktabQuiz.Models.DataBaseContexts;
using MaktabQuiz.Ripository.Interfaces;
using MaktabQuiz.Ripository.Ripositorys;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
;
builder.Services.AddDbContext<ApplicationDbContext>(opthons =>
{
    opthons.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IDapperContext, DapperContext>();
builder.Services.AddScoped<ICateguryRipository, CategoryRepository>();
builder.Services.AddScoped<IProductRipository, ProductRipository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
