using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Options;
public sealed class EmailOptions
{
    public string Email { get; set; } = string.Empty;
    public string SMTP { get; set; } = string.Empty;
    public int PORT { get; set; }
    public string Password { get; set; }
    public bool SSL { get; set; }
    
}
