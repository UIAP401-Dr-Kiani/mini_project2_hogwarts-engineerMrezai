using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;

namespace hogward;

public partial class DumbledoreMassageSender : Window
{
    public DumbledoreMassageSender()
    {
        InitializeComponent();
    }
    private void MassageSender_OnClick(object sender, RoutedEventArgs e)
    {
        int count = 0;
        var _Student =  Program.AuthorizePersonsDetecter("studnt");
        for (int i = 0; i < _Student.Length; i++)
        {
            count++;
            _Student[i].massage[0] = Massage.Text + DatePicker.Text + Hour.Text + Min.Text + Time.Text + count;
        }
        string json = JsonConvert.SerializeObject(_Student);
        System.IO.File.WriteAllText("JSON_DATA.json", json);
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
