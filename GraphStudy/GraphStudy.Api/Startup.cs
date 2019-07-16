﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.GraphiQL;
using GraphStudy.Api.Schema;
using GraphStudy.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using GraphQL.Instrumentation;
using Newtonsoft.Json;

namespace GraphStudy.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<GraphStudySchema>();
            services.AddSingleton<UserType>();
            services.AddSingleton<QueryType>();
            services.AddSingleton<IUserService, UserService>();
            
            services.AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));

            // Add GraphQL services and configure options
            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
                options.ExposeExceptions = true;
            })
                .AddWebSockets() // Add required services for web socket support
                .AddDataLoader(); // Add required services for DataLoader support
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // this is required for websockets support
            app.UseWebSockets();

            // use websocket middleware for ChatSchema at path /graphql
            app.UseGraphQLWebSockets<GraphStudySchema>("/graphql");

            // use HTTP middleware for ChatSchema at path /graphql
            app.UseGraphQL<GraphStudySchema>("/graphql");

            //去点另外两个UI，因为我们刚刚添加的包就是Playground，所以保留这个就行
            // use graphql-playground middleware at default url /ui/playground
            //app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());

            app.UseGraphiQLServer(new GraphiQLOptions());
        }
    }
}
