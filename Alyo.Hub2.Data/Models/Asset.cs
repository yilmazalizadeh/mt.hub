using System.ComponentModel.DataAnnotations;

namespace Alyo.Hub2.Data.Models;

public class Asset
{
    [Key] public Guid Id { get; init; }

    [StringLength(500, MinimumLength = 5)]
    [Required]
    public string Title { get; init; } = string.Empty;

    [StringLength(1000)] public string? FarsiDescription { get; init; }

    [StringLength(1000)] public string? Description { get; init; }

    [StringLength(500, MinimumLength = 10)]
    [Required]
    public string Thumbnail { get; init; } = null!;

    [StringLength(500, MinimumLength = 10)]
    [Required]
    public string VideoUrl { get; init; } = null!;

    [StringLength(500, MinimumLength = 10)]
    [Required]
    public string DownloadUrl { get; init; } = null!;
}