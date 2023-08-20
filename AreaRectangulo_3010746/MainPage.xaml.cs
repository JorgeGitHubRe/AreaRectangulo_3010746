namespace AreaRectangulo_3010746
{
    public partial class MainPage : ContentPage
    {
 
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(bas.Text);
            double a = Convert.ToDouble(altu.Text);

            p.Text = "El perímetro es: " + (b + b + a + a);
            s.Text = "La superficie es: " + (b * a);
        }
    }
}