using RegistroEstudiantes.ViewModels;

namespace RegistroEstudiantes.Views;

public partial class RegistroPage : ContentPage
{
    public RegistroPage(RegistroViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}