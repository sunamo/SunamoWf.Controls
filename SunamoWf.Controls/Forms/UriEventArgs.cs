namespace SunamoWf.Controls;

/// <summary>
/// Event data carrying a Uri.
/// </summary>
public class UriEventArgs : EventArgs
{
    /// <summary>
    /// The carried address.
    /// </summary>
    public Uri Uri { get; }

    /// <summary>
    /// Creates event data for the given address.
    /// </summary>
    public UriEventArgs(Uri uri)
    {
        Uri = uri;
    }
}

/// <summary>
/// Handler for events that carry a Uri.
/// </summary>
public delegate void UriEventHandler(object sender, UriEventArgs e);
