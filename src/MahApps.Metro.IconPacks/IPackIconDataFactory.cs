using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MahApps.Metro.IconPacks
{
    public interface IPackIconDataFactory
    {
        string GetValue(object key);
    }
}
