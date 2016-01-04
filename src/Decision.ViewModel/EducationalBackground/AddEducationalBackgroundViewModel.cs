﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;
using Decision.DomainClasses.Entities.TeacherInfo;

// ReSharper disable InconsistentNaming

namespace Decision.ViewModel.EducationalBackground
{
    /// <summary>
    /// ویومدل درج سوابق استاد
    /// </summary>
    public class AddEducationalBackgroundViewModel
    {
        public AddEducationalBackgroundViewModel()
        {
            StudyFields = new List<SelectListItem>();
            Institutions = new List<SelectListItem>();
            EntryDate = GraduationDate = DateTime.Now;
        }

        #region Properties
        /// <summary>
        /// نوع تحصیلات 
        /// حوزوی / دانشگاهی
        /// </summary>
        [DisplayName("نوع تحصیلات")]
        [Required(ErrorMessage = "لطفا نوع تحصیلات را مشخص کنید ")]
        public  EducationalType EducationalType { get; set; }

        /// <summary>
        /// مقطع تحصیلات حوزوی
        /// </summary>
        [DisplayName("مقطع تحصیلات حوزی")]
        public  HozeDegrees HosDegree { get; set; }

        /// <summary>
        /// مقطع تحصیلی دانشگاهی
        /// </summary>
        [DisplayName("مقطع تحصیلات دانشگاهی")]
        public  AcademicDegrees AcademicDegree { get; set; }

        /// <summary>
        /// موضوع پایان نامه مدرک
        /// </summary>
        [Required(ErrorMessage = "لفطا موضوع پایان نامه را وارد کنید")]
        [DisplayName("موضوع پایان نامه")]
        public  string ThesisTopic { get; set; }

        /// <summary>
        /// زمان فارغ التحصیل شدن در این مدرک
        /// </summary>
        [DisplayName("تاریخ فارغ التحصیلی")]
        [Required(ErrorMessage = "لفطا تاریخ فارغ التحصیل شدن در این مدرک را وارد کنید")]
        public  DateTime GraduationDate { get; set; }

        /// <summary>
        /// تاریخ ورود به مقطع تحصیلی
        /// </summary>
        [DisplayName("تاریخ شروع مقطع")]
        [Required(ErrorMessage = "لفطا تاریخ  ورود به مقطع تحصیلی را وارد کنید")]
        public  DateTime EntryDate { get; set; }

        /// <summary>
        /// استاد مشاور
        /// </summary>
       
        [StringLength(50, ErrorMessage = "نام استاد مشاور باید بین دو تا 50 کاراکتر باشد")]
        [DisplayName("استاد مشاور")]
        public  string Advisor { get; set; }

        /// <summary>
        /// استاد راهنما
        /// </summary>
        
        [StringLength(50, ErrorMessage = "نام استاد راهنما باید بین دو تا 50 کاراکتر باشد")]
        [DisplayName("استاد راهنما")]
        public  string Supervisor { get; set; }

        /// <summary>
        ///توضیحاتی از قبیل نام سایر اساتید مشاور و داوران
        /// </summary>
        
        [DisplayName("توضیحات")]
        public  string Description { get; set; }
        /// <summary>
        /// معدل کل مقطع
        /// </summary>
        [DisplayName("معدل کل")]
        [Range(0.00, 20.00, ErrorMessage = "نمره معدل کل میبایست بین صفر تا ۲۰ باشد")]
        [RegularExpression(@"\d+(\.\d{2})?", ErrorMessage = "لطفا معدل کل را به شکل صحیح وارد کنید")]
        public  decimal GPA { get; set; }
        /// <summary>
        /// نمره پایان نامه
        /// </summary>
        [DisplayName("نمره پایان نامه")]
        [Range(0.00,20.00, ErrorMessage = "نمره پایان نامه میبایست بین صفر تا ۲۰ باشد")]
        [RegularExpression(@"\d+(\.\d{2})?", ErrorMessage = "لطفا نمره پایان نامه را به شکل صحیح وارد کنید")]
        public  decimal ThesisScore { get; set; }
        /// <summary>
        /// میزان ارتباط با پست کاری
        /// </summary>
        [DisplayName("ارتباط با پست کاری")]
        [Range(0, 10, ErrorMessage = " عدد وارد شده میبایست بین صفر تا ۱۰ باشد")]
        public  int RelatedToOrganizationPosition { get; set; }

        /// <summary>
        /// اسکن فایل ضمیمه مدرک تحصیلی
        /// </summary>
        public  string AttachmentScan { get; set; }

        /// <summary>
        /// اسکن فایل ضمیمه مدرک تحصیلی
        /// </summary>
        [DisplayName("فایل ضمیمه مدرک")]
        public  HttpPostedFileBase AttachmentFile { get; set; }

        /// <summary>
        /// آی دی استاد صاحب مدرک
        /// </summary>
        [DisplayName("استاد")]
        [Required]
        public  Guid TeacherId { get; set; }

        /// <summary>
        /// آی دی موسسه آموزشی
        /// </summary>
        [Required(ErrorMessage = "لطفا موسسه آموزشی را انتخاب کنید")]
        [DisplayName("موسسه آموزشی")]
        public  Guid InstitutionId { get; set; }

        /// <summary>
        /// آی دی عنوان رشته تحصیلی
        /// </summary>
        [Required(ErrorMessage = "لطفا رشته تحصیلی را انتخاب کنید")]
        [DisplayName("رشته تحصیلی")]
        public  Guid StudyFieldId { get; set; }
        #endregion

        #region SelectListItems
        /// <summary>
        /// لیست عنوان رشته های تحصیلی برای لیست آبشاری در ویو
        /// </summary>
        public  IEnumerable<SelectListItem> StudyFields { get; set; }

        /// <summary>
        /// لیست موسسه های آموزشی برای لیست آبشاری در ویو
        /// </summary>
        public  IEnumerable<SelectListItem> Institutions { get; set; }
        #endregion
    }
}