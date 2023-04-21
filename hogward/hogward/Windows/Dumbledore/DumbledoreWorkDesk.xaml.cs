using System.Windows;

namespace hogward;

public partial class DumbledoreWorkDesk : Window
{
    public DumbledoreWorkDesk()
    {
        InitializeComponent();
    }

    private void Ticket_OnClick(object sender, RoutedEventArgs e)
    {
        DumbledoreMassageSender dumbledoreMassageSender = new DumbledoreMassageSender();
        dumbledoreMassageSender.Show();
       
    }
}