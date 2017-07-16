using System;
using BLToolkit.DataAccess;

namespace Entities
{
    public class Card
    {
        [PrimaryKey, Identity]
        public int ID { get; set; }
        public bool Deleted { get; set; }
    }
}
