using ReactiveUI.SourceGenerators;

namespace AvaloniaCross.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableAsProperty] private string _userName = string.Empty;

    [ObservableAsProperty] private string _greeting = "Welcome to Avalonia!";

    [ObservableAsProperty] private string _inputText = string.Empty;

    [ObservableAsProperty] private string _username = string.Empty;

    [Reactive] private string _password = string.Empty;
}