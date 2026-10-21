using System;

namespace StageSync.Models.Tables
{
    public class TblCmsContentsModel
    {
        public int cmsID { get; set; }
        public string pageName { get; set; }
        public string sectionKey { get; set; }
        public string contentType { get; set; }
        public string contentValue { get; set; }
        public int? updatedBy { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
    }
}
