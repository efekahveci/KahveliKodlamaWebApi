using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NpgsqlTypes;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveliKodlama
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //    static string PushSeriLogProperties(HttpContext httpContext)
            //    {
            //        return httpContext.User.Identity?.Name;
            //    }

            //IDictionary<string, ColumnWriterBase> columnWriters = new Dictionary<string, ColumnWriterBase>
            //{
            //    {"message", new RenderedMessageColumnWriter(NpgsqlDbType.Text) },
            //    {"message_template", new MessageTemplateColumnWriter(NpgsqlDbType.Text) },
            //    {"level", new LevelColumnWriter(true, NpgsqlDbType.Varchar) },
            //    {"raise_date", new TimestampColumnWriter(NpgsqlDbType.Timestamp) },
            //    {"exception", new ExceptionColumnWriter(NpgsqlDbType.Text) },
            //    {"properties", new LogEventSerializedColumnWriter(NpgsqlDbType.Jsonb) },
            //    {"props_test", new PropertiesColumnWriter(NpgsqlDbType.Jsonb) },
            //    {"machine_name", new SinglePropertyColumnWriter("MachineName", PropertyWriteMethod.ToString, NpgsqlDbType.Text, "test burasý") },
            //    {"efesutun", new  RenderedMessageColumnWriter(NpgsqlDbType.Text)}

            //};

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

            //Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration)
            //    .Enrich.WithMachineName()
            //    .Enrich.WithEnvironmentUserName()
            //    .CreateLogger();

            //Log.Information("TEST");



            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration)
                .Enrich.WithMachineName()
                .Enrich.WithEnvironmentName()
                .Enrich.FromLogContext()
            .CreateLogger();
            Log.Warning("Starting up");


            //Log.Verbose("Verbose");
            //Log.Debug("Debug");
            //Log.Information("Information");
            //Log.Warning("Warning");
            //Log.Error("Error");
            //Log.Fatal("Fatal");










            CreateHostBuilder(args).Build().Run();




        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureLogging(configureLogging =>
            {
                configureLogging.ClearProviders();
            }).UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
