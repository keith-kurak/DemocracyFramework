using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktk.Framework.Forms.MVVM
{
    /// <summary>
    /// Implement the ability to close a Window from a view model
    /// </summary>
    public interface ICloseable
    {
        Action CloseAction { get; set; }
    }
}
