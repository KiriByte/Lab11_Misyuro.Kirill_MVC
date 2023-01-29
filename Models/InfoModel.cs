using System.Text;

namespace Lab11_Misyuro.Kirill_MVC.Models;

public class InfoModel
{
    public string UserName { get; }
    public string EnvName{ get; }
    public string AppName{ get; }
    public string Host{ get; }
    public string Protocol{ get; }

    public InfoModel(HttpRequest app, IWebHostEnvironment web)
    {
        UserName = "Kirill Misyuro";
        //envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        EnvName = web.EnvironmentName;
        AppName = web.ApplicationName;
        Host = app.Host.Host;
        Protocol = app.Protocol;
    }

    
}