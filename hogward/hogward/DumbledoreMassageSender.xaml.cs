using System.IO;
using System.Runtime.InteropServices.JavaScript;
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
    }
}
