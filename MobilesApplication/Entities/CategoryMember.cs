using System;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;

namespace Entities
{
    [TableName("CategoryMembers")]
    public class CategoryMember
    {
        [MapField("Id")][PrimaryKey]
        public int ID { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Location;
        }
    }
}
