namespace TestCustomControls.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    private string? _firstName;

    [ObservableProperty]
    private string? _myMessage;

    public MainViewModel()
    {
        _myMessage = "Hello World!";
    }

}