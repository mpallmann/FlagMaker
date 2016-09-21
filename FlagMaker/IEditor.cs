using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagMaker
{
    public interface IEditor
    {
        event EventHandler SettingsChanged;
    }
}
