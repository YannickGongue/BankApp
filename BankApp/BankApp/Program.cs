using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAppClassLibrary;
using BankAppControlLibrary;

namespace BankApp
{
    static class Program
    {
        private static string strConnectionString; 

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            strConnectionString = ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString;

            // Build the DI container
            var services = new ServiceCollection();

            services.AddDbContext<dbBankAppContext>(options =>
              options.UseSqlServer(strConnectionString));

            services.AddScoped<MCustomers>();
            services.AddScoped<MAccounts>();
            services.AddScoped<MTransactions>();
            services.AddScoped<IRepository, Repositories>();

            services.AddTransient<frmBankApp>();

            var serviceProvider = services.BuildServiceProvider();

            Application.Run(serviceProvider.GetRequiredService<frmBankApp>());
        }   

    }
}
