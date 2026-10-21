using System;

namespace StageSync.Models.Tables
{
    public class TblPerformerTypesModel
    {
        public int typeID { get; set; }
        public string typeName { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
    }
}
