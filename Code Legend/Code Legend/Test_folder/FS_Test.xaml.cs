using Xamarin.Google.Crypto.Tink.Signature;

namespace Code_Legend;

public partial class FS_Test : ContentPage
{
    public string[] questions = { "Label can be?", "What is Button defines?", "When the Clicked event raised?", "What is Image defines?" , "What StackLayout is used for?", "What views does HorizontalStackLayout organize?", "To position Grid cells is using?" };

    public string[] answer1 = { "colored, spaced", "Clicked", "When the Button tap finger or mouse pointer is released from the button’s surfac.", "Aspect, Clicked, IsAnimationPlaying, Source", "To organize child views in a one-demensional horizontal stack.", "child", "RowDefinition and ColumnDefinitions" };
    public string[] answer2 = { "colored, text decorated; ", "Clicked, Pressed, Released", "When finger or mouse pointer presses on a Button.", "Aspect, Source, IsAnimationPlaying, IsLoading, IsOpaque, Source.", "To organize child views in a one-demensional vertical stack.", "It doesn’t organize views", "RowDefinition and ColumnDefinitions" };
    public string[] answer3 = { "colored, spaced, text decorated", "Clicked, Pressed", "When finger or mouse pointer presses on a Button.", "Aspect, IsAnimationPlaying, IsLoading, Source", "To organize elements in a one-demensional stack", "I don’t know.", "Grid.ColumnSpan and Grid.RowSpan" };

    public int clicks = 0;
    public int score = 0;

	public FS_Test()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        AddTest();
    }

    private async void NextBtn_Clicked(object sender, EventArgs e)
    {

        if (check1.IsChecked)
        {
            clicks++;

            progressBar.Progress += 0.14;

            if (clicks <= 0)
            {
                clicks = 0;
            }
            else if (clicks >= questions.Length + 1)
            {
                await Navigation.PopAsync();
            }

            AddTest();
        }

        if (check2.IsChecked)
        {
            clicks++;

            progressBar.Progress += 0.14;

            if (clicks <= 0)
            {
                clicks = 0;
            }
            else if (clicks >= questions.Length + 1)
            {
                await Navigation.PopAsync();
            }

           AddTest();
        }

        if (check3.IsChecked)
        {
            clicks++;

            progressBar.Progress += 0.14;

            if (clicks <= 0)
            {
                clicks = 0;
            }
            else if (clicks >= questions.Length + 1)
            {
                await Navigation.PopAsync();
            }

            AddTest();
        }

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        clicks--;

        progressBar.Progress -= 0.14;

        if (clicks <= 0)
        {
            clicks = 0;
        }

        AddTest();
    }

    private void UpdateQ()
    {
        question.Text = clicks.ToString() + " / " + questions.Length.ToString() + " Questions";
    }

    private void AddTest()
    {
        Test test = new Test();

        UpdateQ();

        test.SetQuestions(clicks, questions, questionLbl);
        test.SetAnswers(clicks, answer1, answer2, answer3, ans1, ans2, ans3);
    }
}