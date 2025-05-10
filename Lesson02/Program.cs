namespace Lesson02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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

            // Chỉnh sửa định tuyến
            app.UseEndpoints(endpoints =>
            {
                // Route mặc định, sẽ sử dụng controller và action nếu không có gì được chỉ định.
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=PtaProduct}/{action=PtaIndex}/{id?}");

                // Cấu hình riêng cho profile (hoặc các route khác bạn muốn).
                endpoints.MapControllerRoute(
                    name: "profile",
                    pattern: "ho-so-cua-toi",
                    defaults: new { controller = "PtaAccount", action = "PtaProfile", id = 1 });
            });

            app.Run();
        }
    }
}
