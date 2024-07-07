var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

// Ётот метод используетс€ дл€ определени€ обработчика запросов.
// ¬ данном случае это л€мбда-выражение, которое принимает параметр context типа HttpContext.
// HttpContext содержит информацию о текущем HTTP-запросе и позвол€ет управл€ть HTTP-ответом
app.Run(async(context)=>
{
    string exampleFolder = "html";
    string exampleName = "htmlpage";

    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync($"wwwroot/{exampleFolder}/{exampleName}.html");
});

app.Run();
