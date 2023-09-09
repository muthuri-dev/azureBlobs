using System.ComponentModel.DataAnnotations;
using DocumentMgtSys.Core.Aggregates.UsersAg;

namespace DocumentMgtSys.Core.Aggregates.FilesAg;

public class AppFile
{
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    public required string Name { get; set; }

    [Required]
    [MaxLength(255)]
    public required string Url { get; set; }

    public int OwnerId { get; set; }

    public required virtual AppUser Owner { get; set; }

    public DateTime TimeStamp { get; set; }
}