﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student
    {
        [Key]
        public long ID { get; set; }

        //فرض شده که حداکثر تعداد کاراکتر ها مجاز را 150 در نظر بگیریم.
        [Display(Name = "نام")]
        [MaxLength(150, ErrorMessage = "تعداد کاراکتر زیاد")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "فیلد ضروری")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [MaxLength(150, ErrorMessage = "تعداد کاراکتر زیاد")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "فیلد ضروری")]
        public string LastName { get; set; }

        [Display(Name = "کد ملی ")]
        [MaxLength(150, ErrorMessage = "تعداد کاراکتر زیاد")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "فیلد ضروری")]
        [RegularExpression(@"^([0-9]{1,150})$", ErrorMessage = "کد ملی را صحیح وارد کنید")]
        public string CodeMeli { get; set; }
      

        [Display(Name = "تاریخ تولد")]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}")]

        [Required(AllowEmptyStrings = false, ErrorMessage = "فیلد ضروری")]
        public DateTime BirthDate { get; set; }
      
      
        public string ImgPath { get; set; }

    }
}
