namespace myControls
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            birthdatePicker.Date = DateTime.Now;
        }


        private void OnSendButtonClicked(object sender, EventArgs e)
        {
            // Einfaches Beispiel: Werte aus Entry und Editor auslesen
            string username = usernameEntry.Text;
            string comment = commentEditor.Text;

            // Wert aus Picker
            string selectedCountry = countryPicker.SelectedItem?.ToString() ?? "Kein Land ausgewählt";

            // Wert aus DatePicker
            DateTime selectedDate = birthdatePicker.Date;

            // Wert aus TimePicker
            TimeSpan selectedTime = reminderTimePicker.Time;

            // Hier könntest du z.B. eine einfache Ausgabe per DisplayAlert machen
            DisplayAlert(
                "Eingaben",
                $"Name: {username}\nKommentar: {comment}\nLand: {selectedCountry}\n" +
                $"Datum: {selectedDate.ToShortDateString()}\n" +
                $"Uhrzeit: {selectedTime}",
                "OK");


        }



    }

}
