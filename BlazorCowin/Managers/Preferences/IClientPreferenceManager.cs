using MudBlazor;
using System.Threading.Tasks;

namespace BlazorCowin.Managers.Preferences
{
    public interface IClientPreferenceManager
    {
        Task<MudTheme> GetCurrentThemeAsync();
        Task<bool> ToggleDarkModeAsync();
    }
}
