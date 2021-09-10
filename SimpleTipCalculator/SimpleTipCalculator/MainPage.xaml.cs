using Xamarin.Forms;

namespace SimpleTipCalculator
{
    public partial class MainPage : ContentPage
    {
        double total = 0;
        double totalTip = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void calcBill(object sender, System.EventArgs e)
        {

            totalTip = double.Parse(guests.Text) * double.Parse(tip.Text);
            totTip.Text = totalTip.ToString();

            total = double.Parse(bill.Text) + double.Parse(totTip.Text);
            totBill.Text = total.ToString();

        }

        private void clear(object sender, System.EventArgs e)
        {
            bill.Text = "";
            tip.Text = "";
            guests.Text = "";

        }
    }
}