namespace KoloryMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            double first_r = Preferences.Get("r", 0);
            double first_g = Preferences.Get("g", 0);
            double first_b = Preferences.Get("b", 0);

            sliderR.Value = first_r;
            sliderG.Value = first_g;
            sliderB.Value = first_b;


            sliderR_ValueChanged(null, null);

        }

        private void sliderR_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Color color = Color.FromRgb(
                sliderR.Value,
                sliderG.Value,
                sliderB.Value);

            rectangle.Fill = new SolidColorBrush(color);

            labelR.Text = Math.Round(255 * color.Red).ToString();
            labelG.Text = Math.Round(255 * color.Green).ToString();
            labelB.Text = Math.Round(255 * color.Blue).ToString();

            Preferences.Set("r", sliderR.Value);
            Preferences.Set("g", sliderG.Value);
            Preferences.Set("b", sliderB.Value);

            reset.IsEnabled = sliderR.Value > 0 || sliderG.Value > 0 || sliderB.Value > 0;

        }

        private void reset_po_kliku(object sender, EventArgs e)
        {
            sliderR.Value = 0;
            sliderG.Value = 0;
            sliderB.Value = 0;

        }

        private void losowanie(object sender, EventArgs e)
        {
            Random rnd = new Random();

            sliderR.Value = rnd.NextDouble();
            sliderG.Value = rnd.NextDouble();
            sliderB.Value = rnd.NextDouble();

        }

    }
}
