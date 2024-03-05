using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.Controllers;
using DakaBlog.Mvc.DataAccesLayer.Abstract;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using DakaBlog.Mvc.DataAccesLayer.Repositories;
using DakaBlog.Mvc.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add Services Blog
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IGenericDal<Blog>, EfBlogRepository>();
builder.Services.AddScoped<IBlogDal, EfBlogRepository>();
builder.Services.AddScoped<IBlogService, BlogManager>();
// Add Services About
builder.Services.AddScoped<IGenericDal<About>, EfAboutRepository>();
builder.Services.AddScoped<IAboutDal, EfAboutRepository>();
builder.Services.AddScoped<IAboutService, AboutManager>();
// Add Services Category
builder.Services.AddScoped<IGenericDal<Category>, EfCategoryRepository>();
builder.Services.AddScoped<ICategoryDal, EfCategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
// Add Services Comment
builder.Services.AddScoped<IGenericDal<Comment>, EfCommentRepository>();
builder.Services.AddScoped<ICommentDal, EfCommentRepository>();
builder.Services.AddScoped<ICommentService, CommentManager>();
// Add Services Contact
builder.Services.AddScoped<IGenericDal<Contact>, EfContactRepository>();
builder.Services.AddScoped<IContactDal, EfContactRepository>();
builder.Services.AddScoped<IContactService, ContactManager>();
// Add Services NewsLetter
builder.Services.AddScoped<IGenericDal<NewsLetter>, EfNewsLetterRepository>();
builder.Services.AddScoped<INewsLetterDal, EfNewsLetterRepository>();
builder.Services.AddScoped<INewsLetterService, NewsLetterManager>();
// Add Services Writer
builder.Services.AddScoped<IGenericDal<Writer>, EfWriterRepository>();
builder.Services.AddScoped<IWriterDal, EfWriterRepository>();
builder.Services.AddScoped<IwriterService, WriterManager>();

builder.Services.AddControllersWithViews(config =>
{
	var policy = new AuthorizationPolicyBuilder()
					.RequireAuthenticatedUser()
					.Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddAuthentication(
	CookieAuthenticationDefaults.AuthenticationScheme).
	AddCookie(x =>
	{
		x.LoginPath = "/Login/Index/";
	}
);
builder.Services.ConfigureApplicationCookie(options =>
{
	options.Cookie.HttpOnly = true; // Tarafýmýzca eriþilebilen bir çerez
	options.ExpireTimeSpan = TimeSpan.FromMinutes(5); // Oturumun 1 gün sonra sona ermesi
	options.LoginPath = "/Login/Index"; // Kullanýcý oturum açmadýðýnda yönlendirilecek sayfa
	options.AccessDeniedPath = "/Login/Index"; // Yetkilendirme hatasý durumunda yönlendirilecek sayfa
	options.SlidingExpiration = true; // Oturumun süresini uzatmak için, her istekte oturum süresini sýfýrlar
});
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
