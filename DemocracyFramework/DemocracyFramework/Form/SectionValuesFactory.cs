using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemocracyFramework.Form
{
    /// <summary>
    /// Create a new instance of SectionValues based on the definition of a section
    /// </summary>
    public class SectionValuesFactory
    {
        private Section section;

        public SectionValuesFactory(Section section)
        {
            this.section = section;
        }

        public SectionValues Create()
        {
            var newSectionValues = new SectionValues(section, this); //TODO: didn't think this through. Maybe Create() needs to take a section?

            newSectionValues.Values = new ValuesFactory(section).Create().ToList();

            return newSectionValues;
        }
    }
}
