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
        AuthorizePersons[] _AuthorizePersons =  Program.AuthorizePersonsDetecter();
        for(int i=0; i<_AuthorizePersons.Length;i++)
        {
            if (_AuthorizePersons[i].role == "student")
            {
                count++;
                _AuthorizePersons[i].massage[0] = Massage.Text + DatePicker.Text + Hour.Text + Min.Text+ Time.Text + count;
            }
        }
        string json = JsonConvert.SerializeObject(_AuthorizePersons);
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
