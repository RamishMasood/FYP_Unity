using UnityEngine;

public class URLOpener : MonoBehaviour
{
    public string urlToOpen; // Specify the URL you want to open

    public void OpenURL()
    {
        // Open the URL using the default system browser
        Application.OpenURL(urlToOpen);
    }
}
