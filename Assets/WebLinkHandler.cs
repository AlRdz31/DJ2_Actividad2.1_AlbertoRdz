using UnityEngine;

public class WebLinkHandler : MonoBehaviour
{
    public void OpenURL(string url)
    {
        if (!string.IsNullOrEmpty(url))
        {
            Application.OpenURL(url);
        }
    }
}
