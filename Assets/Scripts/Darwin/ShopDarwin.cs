using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using TMPro;

public class ShopDarwin : MonoBehaviour
{
    public GameObject Shop;
    public GameObject Darwin;
    public GameObject shopPanel;
    float distance;
    bool isShopOpen = false;
    public int potatoprice = 5;
    public TextMeshProUGUI NotEnoghMoney;


    void Start()
    {
        shopPanel.SetActive(false);
        NotEnoghMoney.text = "";
    }
    void Update()
    {
        
        
        distance = Vector2.Distance(Shop.transform.position, Darwin.transform.position);

        if ((distance <= 3) && (isShopOpen == false) && (Input.GetKeyUp(KeyCode.Q)))
        {
            Invoke("openshop", 0.1f);
        }

        if ((isShopOpen == true) && (Input.GetKeyUp(KeyCode.Q)))
        {
            shopPanel.SetActive(false);
            isShopOpen = false;
            Debug.Log("Shop Close");
        }

        if ((isShopOpen == true) && (Input.GetKeyUp(KeyCode.B)))
        {
            if (MoneyDarwin.Money - potatoprice >= 0)
            {
                MoneyDarwin.Money -= potatoprice;
                NotEnoghMoney.text = "";
                PotatoSeedsDarwin.NoOfSeeds += 1;
            }
            else
            {
                NotEnoghMoney.text = "NotEnoughMoney";
            }
        }
    }
    void openshop()
    {
        shopPanel.SetActive(true);
        isShopOpen = true;
       
    }
}
