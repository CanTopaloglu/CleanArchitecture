using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public sealed class AppRole : IdentityRole<Guid>
{
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    [NotMapped] //entity framework'den notmapped ile db'e gönderirken bunu kaldırır.Maplemede gözükmez.
    public override string? ConcurrencyStamp { get; set; } 
}
