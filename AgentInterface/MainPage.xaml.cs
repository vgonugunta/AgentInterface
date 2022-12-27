using Microsoft.Maui.Controls.Xaml;

namespace AgentInterface;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSubmitButtonClicked(object sender, EventArgs e)
    {
        count += 10;

        var selectedE10State = picker.SelectedItem;

        var stateBegin = BeginCheckBox.IsChecked ? "Begin State" : null;
        var stateEnd = EndCheckBox.IsChecked ? "End State" : null;


        SemanticScreenReader.Announce(SubmitState.Text);
    }
}

