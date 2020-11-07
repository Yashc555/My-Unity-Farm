using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneySuperAlex : MonoBehaviour
{
    TextMeshProUGUI MoneyText;
    public static int Money = 20;
    
    void Start()
    {
        MoneyText = GetComponent<TMPro.TextMeshProUGUI>();
        
    }
    void Update()
    {
        MoneyText.text = "Money :" + Money;
    }
}
