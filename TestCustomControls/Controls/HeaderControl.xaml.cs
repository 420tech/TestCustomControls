using Maui.BindableProperty.Generator.Core;
namespace TestCustomControls.Controls;

public partial class HeaderControl : VerticalStackLayout
{
    [AutoBindable()]
    private readonly string? _firstName;

    [AutoBindable(DefaultBindingMode = nameof(BindingMode.OneWayToSource))]
    private readonly string? _message;

    public HeaderControl()
    {
        InitializeComponent();
    }
}