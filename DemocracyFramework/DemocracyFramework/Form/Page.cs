using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemocracyFramework.Form
{
    /// <summary>
    /// A single instance of the form definition with entered data. Includes all data for the top level section and all children
    /// </summary>
    public class Page
    {
        public Page(Definition definition)
        {
            this.Definition = definition;
            this.Values = new SectionValuesFactory(definition.TopLevelSection).Create();
        }
        /// <summary>
        /// structure defined for the entire page
        /// </summary>
        public Definition Definition { get; set; }

        public SectionValues Values { get; set; }
    }
}
