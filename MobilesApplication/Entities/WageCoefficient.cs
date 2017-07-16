using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;

namespace Entities
{
    [TableName("WageCoefficients")]
    public class WageCoefficient:Card
    {
        public float Point { get; set; }
        public string AdminID { get; set; }
        public DateTime DateEstablished { get; set; }

        [Association(ThisKey = "AdminID", OtherKey = "UseName", CanBeNull = false)]
        public Member MemberInfo { get; set; }

        [Association(ThisKey = "ID", OtherKey = "CoefficientsID", CanBeNull = true)]
        public List<Wage> WagesInfo { get; set; }

    }
}
