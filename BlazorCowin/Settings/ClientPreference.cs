using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCowin.Settings
{
    public interface IPreference
    {
    }

    public record ClientPreference : IPreference
    {
        public bool IsDarkMode { get; set; }
    }
}
