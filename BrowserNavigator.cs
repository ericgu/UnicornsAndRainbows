using System;
using System.Diagnostics;

public interface IBrowserNavigator
{
    void NavigateToUrl(Uri uri);
}

public class BrowserNavigator : IBrowserNavigator
{
    public void NavigateToUrl(Uri uri)
    {
        Process.Start(uri.OriginalString);
    }
}