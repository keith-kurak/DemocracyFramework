using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemocracyFramework.Form
{
    /// <summary>
    /// Turns a single section into a list of Values
    /// </summary>
    public class ValuesFactory
    {
        private Section section;

        public ValuesFactory(Section section)
        {
            this.section = section;
        }

        public IEnumerable<Value> Create()
        {
            var valueList = new List<Value>();
            //TODO: order and default values and other stuff

            foreach(Field f in this.section.Fields)
            {
                var value = new Value();
                value.Field = f;
                value.Value = "";

                valueList.Add(value);
            }

            return valueList;
        }
    }
}
