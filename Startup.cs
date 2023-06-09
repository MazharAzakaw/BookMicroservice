﻿using BookMicroservice.DBContexts;
using BookMicroservice.Repository;
using Microsoft.EntityFrameworkCore;
namespace BookMicroservice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookContext>(o => o.UseSqlServer(Configuration.GetConnectionString("BookDatabase")));
            services.AddTransient<IBookRepository, BookRepository>();      
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
               
                    app.UseSwagger();
                    app.UseSwaggerUI();

            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
        }
    }
}
