using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace exam0607.Models
{
    [MetadataType(typeof(NewsMetadata))]
    public partial class News
    {

    }

    public class NewsMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "請填寫欄位")]
        [Display(Name = "欄位")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "欄位 標題 必須是最大長度為 50 的字串。")]

        public string Title { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "內容")]

        public string Content { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "發布日期")]

        public System.DateTime PublishDate { get; set; }
    }
}