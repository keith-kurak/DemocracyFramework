using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemocracyFramework.Form
{
    /// <summary>
    /// Pairing of all fields in a section and their values
    /// </summary>
    public class SectionValues
    {
        private Section section;
        private SectionValuesFactory sectionValuesFactory;

        public SectionValues(Section section, SectionValuesFactory sectionValuesFactory)
        {
            this.section = section;
            this.sectionValuesFactory = sectionValuesFactory;
        }

        public IList<Value> Values { get; set; }

        /// <summary>
        /// List of all child records
        /// </summary>
        public IList<SectionValues> ChildValuesRecords { get; set; }

        /// <summary>
        /// Add a new record to enter in ChildValuesRecords
        /// </summary>
        public void AddNewChildRecord()
        {
            var sectionValues = sectionValuesFactory.Create();

            this.ChildValuesRecords.Add(sectionValues);
        }
    }
}
