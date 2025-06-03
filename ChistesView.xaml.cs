using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReyesMProgII;

public partial class ChistesView : ContentPage
{
    public ChistesView()
    {
        InitializeComponent();
    }
    private void OtroChisteButton(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new AboutView());
    }
}