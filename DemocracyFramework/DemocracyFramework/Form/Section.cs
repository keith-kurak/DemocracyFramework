using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemocracyFramework.Form
{
    /// <summary>
    /// A group of fields at one level of the form
    /// </summary>
    public class Section
    {
        public IEnumerable<Field> Fields { get; set; }

        /// <summary>
        /// Child section. If this section is the master, then the Child section would be the detail. User can add infinite child records
        /// </summary>
        public Section ChildSection { get; set; }

        //TODO: min and max number of child records
    }
}
