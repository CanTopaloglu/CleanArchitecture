using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace CleanArchitecture.Presentation.Filters;

public class TestFilterAttribute : Attribute, IActionFilter, IAuthorizationFilter
{
    private readonly Stopwatch stopwatch;
    public TestFilterAttribute()
    {
        
    }

    public void OnActionExecuted(ActionExecutedContext context) //Uygulamanın bitişi esnasında
    {
        stopwatch.Stop();
        Console.WriteLine("Ending..." + stopwatch.ElapsedMilliseconds);
    }

    public void OnActionExecuting(ActionExecutingContext context) //Uygulama çalıştığı esnada
    {
        stopwatch.Start();
        //loglama işlemi yapabiliriz
        //Mail gönderme işlemi olabilir
        //cachleme
        Console.WriteLine("Starting...");
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        //Rol kontrolü yapabiliyoruz Authorization işlemi için 
        throw new NotImplementedException();
    }
}
