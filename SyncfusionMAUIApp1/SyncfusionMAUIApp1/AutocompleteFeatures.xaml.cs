using System.Collections.ObjectModel;
using Nager.Country;
using Syncfusion.Maui.DataSource.Extensions;
using Syncfusion.Maui.Inputs;

namespace SyncfusionMAUIApp1;
///<summary>
///AutocompleteFeatures class
///</summary>
public partial class AutocompleteFeatures : ContentPage
{
    ///<summary>
    ///AutocompleteFeatures constructor
    ///</summary>
	public AutocompleteFeatures()
	{
		InitializeComponent();
	}

    private void autoComplete_SelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
    {
        if (autoComplete != null)
        {
            var c = (ICountryInfo)autoComplete.SelectedValue;
            DisplayAlert("Country Selected", c.CommonName, "Close");
        }
    }
}
///<summary>
///AutocompleteFeatures Model class
///</summary>
public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}
///<summary>
///AutocompleteFeatures ViewModel class
///</summary>
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    ///<summary>
    ///AutocompleteFeatures ViewModel class constructor
    ///</summary>
    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>();
        this.SocialMedias.Add(new SocialMedia() { Name = "Facebook", ID = 0 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Google Plus", ID = 1 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Instagram", ID = 2 });
        this.SocialMedias.Add(new SocialMedia() { Name = "LinkedIn", ID = 3 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Skype", ID = 4 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Telegram", ID = 5 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Televzr", ID = 6 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tik Tok", ID = 7 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tout", ID = 8 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tumblr", ID = 9 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Twitter", ID = 10 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Vimeo", ID = 11 });
        this.SocialMedias.Add(new SocialMedia() { Name = "WhatsApp", ID = 12 });
        this.SocialMedias.Add(new SocialMedia() { Name = "YouTube", ID = 13 });
    }
}

public class CountryViewModel
{
    public ObservableCollection<ICountryInfo> Countries { get; set; }
    public CountryViewModel()
    {
        var countryProvider = new CountryProvider();
        this.Countries = countryProvider.GetCountries().ToObservableCollection();
    }
}