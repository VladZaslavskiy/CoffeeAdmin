using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeAdmin.Domain.ApiModels
{
    public class MakeBuildModel
    {
        public int CoffeeId { get; set; }
        public int Quontity { get; set; }
    }

    public class BillBuild
    {
        public IEnumerable<MakeBuildModel> positions { get; set; }
    }
}
