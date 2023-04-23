using System.IO;
using System.Windows;

namespace hogward;

public partial class DumbledoreMassageSender : Window
{
    public DumbledoreMassageSender()
    {
        InitializeComponent();
    }
    private void MassageSender_OnClick(object sender, RoutedEventArgs e)
    {
        using (StreamWriter writer = new StreamWriter("Dumbledore/Massage.txt"))
        {
            writer.WriteLine(this.Massage.Text + "\n" + DatePicker.Text + "\n" + Hour.Text + ":" + Min.Text + " " + Time.Text);
        }
        MessageBox.Show("Massage sanded successfully");
    }

    private void Refresh_Click(object sender, RoutedEventArgs e)
    {
        Massage.Text = "";
        DatePicker.Text = "";
        Hour.Text = "";
        Min.Text = "";
        Time.Text = "";
    }
}
