using System.Diagnostics;

namespace ContainsKeySample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        var dictionary = Application.Current.Resources.MergedDictionaries.FirstOrDefault();
        if ( dictionary is not null ) {
            Debug.WriteLine($"dict.ContainsKey(\"Primary\")   => {dictionary.ContainsKey("Primary")}");
            Debug.WriteLine($"dict.Keys.Contains(\"Primary\") => {dictionary.Keys.Contains("Primary")}");

            Debug.WriteLine("Keys in dictionary:");
            dictionary.Keys.ToList().ForEach(k => Debug.WriteLine($"-> {k}"));
        }
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


