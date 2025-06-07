using CRUD_UoW.Forms;
using CRUD_UoW.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CRUD_UoW
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var services = new ServiceCollection();
            services.AddTransient<MainForm>();
            services.AddScoped<IUoW, UoW>();
            services.AddScoped(provider => new DBContext());


            using (ServiceProvider provider = services.BuildServiceProvider())
            {
                using (DBContext context = provider.GetRequiredService<DBContext>())
                {
                    MainForm form = provider.GetRequiredService<MainForm>();
                    Application.Run(form);
                }
            }

        }
    }
}
