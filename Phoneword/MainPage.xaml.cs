namespace Phoneword
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        
        async void OnCall(object sender, EventArgs e)
        {
            string cipherPhoneNumber = ph_no.Text;
            string? decCipherPhoneNumber = De_cipher.ToNumber(cipherPhoneNumber, Dialer); ;
            if (await this.DisplayAlert("Dial", decCipherPhoneNumber, "Call", "Decline"))
            {
                try
                {
                    if(PhoneDialer.Default.IsSupported && !string.IsNullOrWhiteSpace(decCipherPhoneNumber))
                    {
                        var uri = new Uri($"tel:{decCipherPhoneNumber}");
                        PhoneDialer.Open(uri.ToString());
                    }
                }
                catch (Exception ex) 
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }

}
