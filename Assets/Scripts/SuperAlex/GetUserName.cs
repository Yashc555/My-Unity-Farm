/*using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro;
// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.

public class GetUserName : MonoBehaviour
{
    TextMeshProUGUI Name;
    void Start()
    {
        Name = GetComponent<TMPro.TextMeshProUGUI>();
        // A correct website page.
        StartCoroutine(GetRequest("http://localhost:8081"));

        // A non-existing page.
        StartCoroutine(GetRequest("https://error.html"));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                Name.text = "Welcome," + webRequest.downloadHandler.text;
            }

        }
    }
}*/