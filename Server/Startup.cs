using GraphQL.Server.Transports.AspNetCore;
//using GraphQL.Server.Transports.WebSockets;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Groups.Schema;
using Groups.Services;
using GraphQL;

namespace Server
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGroupService, GroupService>();
            services.AddSingleton<ICustomerService, ClientService>();
            services.AddSingleton<GroupType>();
            services.AddSingleton<ClientType>();
            services.AddSingleton<GroupsQuery>();
            services.AddSingleton<GroupsSchema>();
            services.AddSingleton<IDependencyResolver>(c=> new FuncDependencyResolver(type => c.GetRequiredService(type)));
            services.AddGraphQLHttp();
            //services.AddGraphQLWebSocket<OrdersSchema>();  use this for client subscriptions!!!!
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseDefaultFiles();
            app.UseStaticFiles();
            //Here where you add Subscriptions
            //app.UseWebSockets();
            //app.UseGraphQLWebSocket<OrdersSchema>(new GraphQLWebSocketsOptions());
            app.UseGraphQLHttp<GroupsSchema>(new GraphQLHttpOptions());
        }
    }
}
