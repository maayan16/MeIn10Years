namespace MeIn10Years;

public partial class InTenYears1 : ContentPage
{
	public InTenYears1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int age = int.Parse(entryAge.Text);
        lblResult.Text = $"In ten years, {entryName.Text} will be {age + 10}.";
    }
}