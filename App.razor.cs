using MudBlazor;

namespace EmployeeManagementApp;

public partial class App
{
    private MudTheme EmployeeManagementTheme { get; init; }

    public App()
    {
        EmployeeManagementTheme = new MudTheme()
        {
            // https://imagecolorpicker.com/color-code/61b551

            Palette = new PaletteLight()
            {
                AppbarText = new MudBlazor.Utilities.MudColor(255, 255, 255, 1),
                AppbarBackground = new MudBlazor.Utilities.MudColor(97, 181, 81, 255),
                Primary = new MudBlazor.Utilities.MudColor(97, 181, 81, 255),
            },
        };
    }
}
