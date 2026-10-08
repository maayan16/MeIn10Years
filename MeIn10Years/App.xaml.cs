using Microsoft.Extensions.DependencyInjection;

namespace MeIn10Years
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new InTenYears1());
        }
    }
}