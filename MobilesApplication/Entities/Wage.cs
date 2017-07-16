using System;
using System.Collections.Generic;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System.Linq;

namespace Entities
{
    [TableName("Wages")]
    public class Wage : Card
    {
        [MapIgnore]
        private readonly DbManager _dataContext = new DbManager();

        public float Premium { get; set; }
        public int TotalDate { get; set; }
        public int CoefficientsID { get; set; }
        public bool IsPay { get; set; }
        public DateTime DateEstablished { get; set; }
        public string AdminID { get; set; }
        public string EmployeeID { get; set; }

        [MapIgnore]
        public float Point
        {
            get;
            set;
        }

        [Association(ThisKey = "CoefficientsID", OtherKey = "ID", CanBeNull = true)]
        public WageCoefficient WageCoefficientInfo { get; set; }

        [Association(ThisKey = "AdminID", OtherKey = "UseName", CanBeNull = false)]
        public Member AdminInfo { get; set; }

        [Association(ThisKey = "EmployeeID", OtherKey = "UseName", CanBeNull = false)]
        public Member EmployeeInfo { get; set; }

        [MapIgnore]
        public string Total { get { return WageCoefficientInfo != null ? (Premium + TotalDate * WageCoefficientInfo.Point) + " USD" : "000"; } }

        [MapIgnore]
        public string AdminName
        {
            get
            {
                Member a = AdminInfo;
                return a != null ? a.FullName : "Null";
            }
        }

        [MapIgnore]
        public string EmployeeName
        {
            get
            {
                return EmployeeInfo != null ? EmployeeInfo.FullName : "Null";
            }
        }

    }
}
