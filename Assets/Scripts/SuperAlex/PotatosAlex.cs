using UnityEngine;
using TMPro;

public class PotatosAlex : MonoBehaviour
{
    TextMeshProUGUI Seeds;
    public static int NoOfSeeds = 0;
    public static int NoOfPotatoesHarvested = 0;

    void Start()
    {
        Seeds = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Seeds.text = "" + NoOfSeeds;
    }
}
