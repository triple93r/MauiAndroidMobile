using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;

namespace SyncfusionMAUIApp1;

public partial class Personalinformation : ContentPage
{
	public Personalinformation()
	{
		InitializeComponent();
	}

    private void dataForm_GenerateDataFormItem(object sender, Syncfusion.Maui.DataForm.GenerateDataFormItemEventArgs e)
    {
        if(e.DataFormItem != null)
        {
            if(e.DataFormItem.FieldName == "Name")
            {
                e.DataFormItem.LeadingView = new Label
                {
                    FontSize = 18,
                    HeightRequest = 24,
                    FontFamily = "InputLayoutIcons.ttf",
                    VerticalTextAlignment = TextAlignment.End,
                    Text = "F"
                };
            }
            else if (e.DataFormItem.FieldName == "PhoneNumber")
            {
                e.DataFormItem.LeadingView = new Label
                {
                    FontSize = 18,
                    HeightRequest = 24,
                    FontFamily = "InputLayoutIcons",
                    VerticalTextAlignment = TextAlignment.End,
                    Text = "E"
                };
            }
            else if (e.DataFormItem.FieldName == "Address")
            {
                e.DataFormItem.LeadingView = new Label
                {
                    FontSize = 18,
                    HeightRequest = 24,
                    FontFamily = "InputLayoutIcons",
                    VerticalTextAlignment = TextAlignment.End,
                    Text = "C"
                };
            }
            else if (e.DataFormItem.FieldName == "Email")
            {
                e.DataFormItem.LeadingView = new Label
                {
                    FontSize = 18,
                    HeightRequest = 24,
                    FontFamily = "InputLayoutIcons",
                    VerticalTextAlignment = TextAlignment.End,
                    Text = "G"
                };
            }
            else
            {
                e.DataFormItem.LeadingView = new Label
                {
                    FontSize = 18,
                    HeightRequest = 24,
                    FontFamily = "InputLayoutIcons                  ",
                    VerticalTextAlignment = TextAlignment.End,
                };
            }
        }

    }

    private void saveButton_Clicked(object sender, EventArgs e)
    {
        //this.dataForm.Validate();
        DisplayAlert("Alert", "Data will be saved!", "OK");
    }
}

public enum Gender
{
    Male,
    Female,
    Other
}

public class ContactInfo
{
    [Display(Name = "First Name", GroupName = "Name", Prompt ="Enter First Name")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "First Name cannot be Empty")]
    [StringLength(10, ErrorMessage = "Name Should not Exceed 10 characters")]
    public string Name { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name Should not be Empty")]
	[Display(Name = "Last Name", GroupName = "Name", Prompt = "Enter Last Name")]
    [StringLength(10, ErrorMessage = "Last Name Should not Exceed 10 characters")]
	public string LastName { get; set; }

    //[Display(Name = "Password", GroupName = "Name", Prompt = "Enter Password")]
    //[Required(AllowEmptyStrings = false, ErrorMessage = "Password Cannot be Empty")]
    //[StringLength(10, ErrorMessage = "Password Should not Exceed 10 characters")]
    //[DataType(DataType.Password)]
    //public string Password { get; set; }

    //[Display(Name = "Gender", GroupName = "Name")]
    //public Gender Gend_er { get; set; }

    [Display(Name = "Land Line", GroupName = "Phone", Prompt = "Enter Contact")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Contact # cannot be Empty")]
    public string PhoneNumber { get; set; }

	[Display(Name = "Mobile", GroupName = "Phone")]
    [DataType(DataType.PhoneNumber)]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile cannot be Empty")]
    public string Phone { get; set; }

    [DataType(DataType.MultilineText)]
    [Display(GroupName = "Address Details", Prompt = "Enter Address")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Address cannot be Empty")]
    public string Address { get; set; }


    [Display(GroupName = "Address Details", Prompt = "Enter City")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "City cannot be Empty")]
    public string City { get; set; }

    //[Display(GroupName = "Address Details")]
    //[Required(AllowEmptyStrings = false, ErrorMessage = "Region cannot be Empty")]
    //public string Region { get; set; }

    //[Display(GroupName = "Address Details")]
    //[Required(AllowEmptyStrings = false, ErrorMessage = "City cannot be Empty")]
    //public string PostalCode { get; set; }

    [Display(GroupName = "Address Details", Prompt = "Enter Country")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Country cannot be Empty")]
    public string Country { get; set; }

    //[Display(GroupName = "Address Details", Prompt = "Enter Fax")]
    //[Required(AllowEmptyStrings = false, ErrorMessage = "Fax cannot be Empty")]
    //public string Fax { get; set; }

    [Display(GroupName = "Mail")]
    public string Email { get; set; }
}

public class DataFormViewModel
{
	public ContactInfo ContactInfo { get; set; }
	public DataFormViewModel()
	{
		this.ContactInfo = new ContactInfo();
	}
}
