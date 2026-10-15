namespace MeIn10Years;

public partial class InTenYearsSlider : ContentPage
{
    private int age;
    public InTenYearsSlider()
    {
        InitializeComponent();
        lblResult.Text = "what will be your age in ten years?";
    }
    private void sliderAge_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        age = (int)sliderAge.Value;
        entryAge.Text = age.ToString();
    }

    private void sliderAge_DragCompleted(object sender, EventArgs e)
    {
        age = (int)sliderAge.Value;
        lblResult.Text = $"In ten years, {entryName.Text} will be {age + 10} years old.";
    }
}