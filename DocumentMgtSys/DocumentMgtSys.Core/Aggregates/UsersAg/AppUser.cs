using System.ComponentModel.DataAnnotations;
using DocumentMgtSys.Core.Aggregates.FilesAg;

namespace DocumentMgtSys.Core.Aggregates.UsersAg;

public class AppUser
{
    public int Id { get; set; }

    [Required]
    [MaxLength(512)]
    public required string SystemId { get; set; }

    public UserRole Role { get; set; }

    public virtual ICollection<AppFile> Files { get; set; } = new List<AppFile>();

    public DateTime TimeStamp { get; set; }
}