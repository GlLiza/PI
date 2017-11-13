using System;
using System.Web.UI;

namespace laba11WebForm
{
    public partial class _Default : Page
    {
        ServiceReference1.XXXServiceSoapClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.client = new laba11WebForm.ServiceReference1.XXXServiceSoapClient();
        }

        protected void Plus_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBoxX.Text);
            int y = Convert.ToInt32(TextBoxY.Text);
            TextBoxResult.Text = Convert.ToString(client.Sum(x, y));
        }

        protected void Minus_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBoxX.Text);
            int y = Convert.ToInt32(TextBoxY.Text);
            TextBoxResult.Text = Convert.ToString(client.Sub(x, y));
        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBoxX.Text);
            int y = Convert.ToInt32(TextBoxY.Text);
            TextBoxResult.Text = Convert.ToString(client.Mul(x, y));
        }

        protected void SetI_Click(object sender, EventArgs e)
        {
            client.SetI(Convert.ToInt32(Set.Text));
        }

        protected void GetI_Click(object sender, EventArgs e)
        {
            Get.Text = client.GetI().ToString();
        }

        protected void Addd_Click(object sender, EventArgs e)
        {
            Add.Text = client.AddI(Convert.ToInt32(AddI.Text)).ToString("D");
        }
    }
}