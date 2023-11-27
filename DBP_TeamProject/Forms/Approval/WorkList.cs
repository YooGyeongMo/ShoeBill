using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_TeamProject.Forms.Approval
{
    internal class WorkList
    {
        private string largeCategory;
        private string mediumCategory;
        private string subCategory;

        public string LargeCategory { get => largeCategory; set => largeCategory = value; }
        public string MediumCategory { get => mediumCategory; set => mediumCategory = value; }
        public string SubCategory { get => subCategory; set => subCategory = value; }
    }
}
