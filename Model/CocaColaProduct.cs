using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class CocaColaProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialCode { get; set; }
        public string Brand_Name { get; set; }
        public string Material_Package { get; set; }
        public string Material_Type { get; set; }
        public string Material_Unit_Size { get; set; }
        public int Material_Size { get; set; }
        public double RemainingQTY { get; set; }
        public string Description { get; set; }
        public int Wholesaler_Id { get; set; }
        public double Suggested_Price_PerCase { get; set; }
        public double Suggested_Price_PerBottle { get; set; }
        public double Actual_Price_PerCase { get; set; }
        public double Actual_Price_PerBottle { get; set; }
        public bool isCokeProduct { get; set; }
        public bool isActive { get; set; }
        public string Image_Path { get; set; }
        public int? Added_By { get; set; }
        public string Added_Date { get; set; }
        public int? Updated_By { get; set; }
        public string Updated_Date { get; set; }
    }
}
