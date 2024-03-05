using Mapsui.Layers;
using Mapsui.Tiling;
using Mapsui.UI.Maui;

namespace Diplom.MapUI;

public class MapPage : ContentView
{
	public MapPage()
    {
        var mapControl = new MapView();
        mapControl.Map?.Layers.Add(OpenStreetMap.CreateTileLayer());
        var map = mapControl.Map;
        mapControl.MyLocationEnabled = true;
        var mylocation = new MyLocationLayer(map);
        //mylocation.UpdateMyLocation();
        Content = mapControl;
    }
}