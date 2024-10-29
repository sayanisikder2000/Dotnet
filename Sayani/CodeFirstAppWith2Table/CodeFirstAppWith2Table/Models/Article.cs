using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstAppWith2Table.Models
{
    [Table("tblArticles")]
    public class Article
    {
        public int? ArticleId { get; set; }
        [Required(ErrorMessage ="Please enter article Title")]
        public string ArticleTitle { get; set; }
        [Required(ErrorMessage ="Please enter article content")]
        public string ArticleContent { get; set; }

        public int TutorialId {  get; set; }
        public Tutorial? Tutorials { get; set; } = null;
    }
}