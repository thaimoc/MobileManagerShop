using System;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using System.Collections.Generic;
using BLToolkit.Data;
using System.Linq;

namespace Entities
{
    [TableName("Members")]
    public class Member
    {
        [MapIgnore]
        private readonly DbManager _dataContext = new DbManager();

        [PrimaryKey]
        public string UseName { get; set; }
        [MapField("Pass")]
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate{ get; set; }
        public bool Gender { get; set; }
        public int NumHouse { get; set; }
        public string Street { get; set; }
        public string Urban { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public int CategoryMemberID { get; set; }
        
        [MapIgnore]
        public string FullName
        {
            get { return string.Format("{0} {1}", LastName, FirstName); }
        }
        [Association(ThisKey = "CategoryMemberID", OtherKey = "ID", CanBeNull = false)]
        public CategoryMember CategoryInfo {
            get { return _dataContext.GetTable<CategoryMember>().Where(cta => cta.ID == CategoryMemberID).FirstOrDefault(); }
            set {
                CategoryMemberID = value.ID;
            }
        }

        [MapIgnore]
        public string CateName
        {
            get { return string.Format("{0}", CategoryInfo != null ? CategoryInfo.Location : "Customer"); }
        }

        [MapIgnore]
        public string Address { get { return string.Format("{0}/{1} - {2} - {3} - {4}", NumHouse, Street, Urban, Town, City); } }

        [Association(ThisKey = "UseName", OtherKey = "AdminID", CanBeNull=true)]
        public List<WageCoefficient> WageCoefficientInfo { get; set; }

        [Association(ThisKey = "UseName", OtherKey = "AdminID", CanBeNull = true)]
        public List<Wage> AdminWagesInfo { get; set; }


        [Association(ThisKey = "UseName", OtherKey = "EmployeeID", CanBeNull = true)]
        public List<Wage> EmloyeeWagesInfo
        {
            //get { return _dataContext.GetTable<Wage>().Where(w => w.EmployeeID == UseName).ToList(); }
            get;
            set;

        }

        [Association(ThisKey="UseName", OtherKey="CusID", CanBeNull=true)]
        public List<Bill> CusBillsInfo { get; set; }

        [Association(ThisKey = "UseName", OtherKey = "SelID", CanBeNull = true)]
        public List<Bill> SelBillsInfo { get; set; }


    }
}
