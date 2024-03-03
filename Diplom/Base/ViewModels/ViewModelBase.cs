using Diplom.LocalizationController;
using static System.GC;

namespace Diplom.Base;

internal class ViewModelBase: INotifyPropertyChanged, IDisposable
{
    #region INotifyPropertyChanged
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string prop = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

    #endregion

    #region Localization

    /// <summary> Синглтон локализации</summary>
    public LocalizationResourceManager LocalizationResourceManager
        => LocalizationResourceManager.Instance;

    #endregion

    #region Disposing

    private bool _disposedValue;

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            _disposedValue = true;
        }
    }
    public void Dispose()
    {
        Dispose(disposing: true);
        SuppressFinalize(this);
    }
    
    #endregion
}