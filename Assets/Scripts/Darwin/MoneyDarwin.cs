using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDarwin : MonoBehaviour
{
    TextMeshProUGUI MoneyText;
    public static int Money = 10;
    
    void Start()
    {
        MoneyText = GetComponent<TMPro.TextMeshProUGUI>();
        
    }
    void Update()
    {
        MoneyText.text = "Money :" + Money;
    }
}
