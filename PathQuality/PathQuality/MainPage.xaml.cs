using Microsoft.Maui.Controls.Shapes;
using Path = Microsoft.Maui.Controls.Shapes.Path;

namespace PathQuality;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private void AddSquiggly_Clicked(object sender, EventArgs e)
    {
        Rect bounds = new Rect(0, 0, 88.03201 * 2, 48 * 2);
        Path trianglePath = new Path();
        var value = new PathGeometryConverter().ConvertFromString("M 10,100 L 100,100 100,50Z");
        trianglePath.Data = (Geometry)value;
        trianglePath.Stroke = Colors.Green;
        Rect position = new Rect(500, 220, bounds.Width, bounds.Height);
        AbsoluteLayout.SetLayoutBounds(trianglePath, position);
        TempViewer.Children.Add(trianglePath);
    }

    private void AddScale_Clicked(object sender, EventArgs e)
    {
        TempViewer.Scale += 1;
        for (int i = TempViewer.Children.Count - 1; i >= 1; i--)
        {
            if (TempViewer.Children[i] is Path path)
            {
                path.Scale = TempViewer.Scale;
            }
        }
    }
}

