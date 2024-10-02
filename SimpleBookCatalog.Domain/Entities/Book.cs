

using SimpleBookCatalog.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace SimpleBookCatalog.Domain.Entities;

public class Book
{
    [Required(ErrorMessage ="please provide a title")]
    public int Id { get; set; }
    [Required(ErrorMessage ="please provide a title")]
    [StringLength(50)]

    public string? Title { get; set; }

    public string? AuthorName { get; set; }
    public DateTime? PublicationDate { get; set; }
    [EnumDataType(typeof(Catagory),ErrorMessage ="please select any catagory")]
    public Catagory CatagoryType { get; set; }
}
