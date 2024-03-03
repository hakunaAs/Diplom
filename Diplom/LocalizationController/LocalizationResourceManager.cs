using Diplom.Resources.Localization;

namespace Diplom.LocalizationController;

internal class LocalizationResourceManager : INotifyPropertyChanged
{
    private LocalizationResourceManager()
    {
        AppLocalization.Culture = CultureInfo.CurrentCulture;
    }

    public static LocalizationResourceManager Instance { get; } = new();

    public object this[string recourceKey]
        => AppLocalization.ResourceManager.GetObject(recourceKey, AppLocalization.Culture) ?? Array.Empty<byte>();

    public event PropertyChangedEventHandler? PropertyChanged;

    public void SetCulture(CultureInfo culture)
    {
        AppLocalization.Culture = culture;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
    }

    public ObservableCollection<CultureInfo> AvailableCulturesCollection =
    [
        new CultureInfo("ru-RU"),
        new CultureInfo("en-US")
    ];
}