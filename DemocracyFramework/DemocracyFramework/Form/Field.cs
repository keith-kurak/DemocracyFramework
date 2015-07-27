using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemocracyFramework.Form
{
    public enum FormFieldDataType { String, Number, Date, DropDown};

    public class Field
    {
        public FormFieldDataType Type { get; set; }

        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        /// <summary>
        /// Order displayed on form
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Order when output to file
        /// </summary>
        public int OutputOrder { get; set; }

        /// <summary>
        /// If true, hide this on the form but still output in file. Useful for making fields obsolete but remaining compatible with old data
        /// </summary>
        public bool IsHidden { get; set; }

        public IEnumerable<string> DropDownValues { get; set; }

        public string DefualtValue { get; set; }
    }
}
