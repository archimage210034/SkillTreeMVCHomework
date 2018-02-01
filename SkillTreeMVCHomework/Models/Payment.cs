using SkillTreeMVCHomework.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SkillTreeMVCHomework.Models
{
    public sealed class Payment
    {
        [Display(Name = "類別")]
        [Required]
        public MoneyTypeEnum moneyType { get; set; }

        [Display(Name = "日期")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required]
        [Remote("NoteFeatureDateValid", "Home")]
        public DateTime datetime { get; set; }

        [Display(Name = "金額")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "「金額」只能輸入正整數")]
        public int count { get; set; } //應該使用更精準的型態 decimal，可是說好不改viewModel

        [Display(Name = "備註")]
        [Required]
        [MaxLength(1000, ErrorMessage = "「備註」最多輸入100個字元")]
        public string remark { get; set; }
    }
}