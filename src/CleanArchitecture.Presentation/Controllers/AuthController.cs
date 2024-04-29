using CleanArchitecture.Application.Features.Auth.Register;
using CleanArchitecture.Application.Utilities;
using CleanArchitecture.Presentation.Abstractions;
using FluentEmail.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace CleanArchitecture.Presentation.Controllers;
public sealed class AuthController : ApiController
{
    private readonly IFluentEmail _fluentEmail;

    public AuthController(IMediator mediator, IFluentEmail fluentEmail) : base(mediator)
    {
        _fluentEmail = fluentEmail;
    }

    [HttpPost]
    //[Validation<RegisterCommandValidator>]
    public async Task<IActionResult> Register(RegisterCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);

        return StatusCode(response.StatusCode, response);
    }

    [HttpGet]
    public async Task<IActionResult> SendTestEmail(CancellationToken cancellationToken)
    {
        //using (MailMessage mail = new MailMessage())
        //{
        //    mail.From = new MailAddress("test@test.com");
        //    mail.To.Add("taner@saydam.com");

        //    mail.Subject = "Test Maili";
        //    mail.Body = "<h1>Bu bir test mailidir!</h1>";
        //    mail.IsBodyHtml = true;

        //    using (SmtpClient smtp = new SmtpClient("localhost", 2525))
        //    {
        //        smtp.UseDefaultCredentials = false;
        //        //smtp.Credentials = new NetworkCredential("", "");
        //        smtp.EnableSsl = false;
        //        //smtp.Port = 25;  vermiyoruz bunu.
        //        await smtp.SendMailAsync(mail);
        //    }

        //    return Ok(new { message = "Mail gönderme işlemi başarıyla tamamlandı!" });
        //}



        return Ok(new { message = "Mail gönderme işlemi başarıyla tamamlandı!" });
    }
}
