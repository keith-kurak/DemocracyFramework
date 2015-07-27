using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktk.Framework.Forms.MVVM
{
    /// <summary>
    /// Interface for a view model that features long-running async task and reports whether or not it is running one via the IsProcessingAsync property
    /// </summary>
    public interface IAsyncTaskable
    {
        bool IsProcessingAsync { get; set; }
    }
}
