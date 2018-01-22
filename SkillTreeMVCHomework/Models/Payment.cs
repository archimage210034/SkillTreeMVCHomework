using SkillTreeMVCHomework.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace SkillTreeMVCHomework.Models
{
    public sealed class Payment
    {
        [Display(Name = "類別")]
        public MoneyTypeEnum moneyType { get; set; }

        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime datetime { get; set; }

        [Display(Name = "金額")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int count { get; set; } //應該使用更精準的型態 decimal，可是說好不改viewModel
    }
}