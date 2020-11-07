using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PotatoSeedsDarwin : MonoBehaviour
{
    TextMeshProUGUI Seeds;
    public static int NoOfSeeds = 0;

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
