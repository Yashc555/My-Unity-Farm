using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using TMPro;

public class ShopSuperAlex : MonoBehaviour
{
    public GameObject Shop;
    public GameObject SuperAlex;
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
        distance = Vector2.Distance(Shop.transform.position, SuperAlex.transform.position);

        if ((distance <= 3) && (isShopOpen == false) && (Input.GetKeyUp(KeyCode.Space)))
        {
            Invoke("openshop", 0.1f);
        }

        if ((isShopOpen == true) && (Input.GetKeyUp(KeyCode.Space)))
        {
            shopPanel.SetActive(false);
            isShopOpen = false;
            Debug.Log("Shop Close");
        }
        
        if((isShopOpen == true) && (Input.GetKeyUp(KeyCode.P)))
        {
            if (MoneySuperAlex.Money - potatoprice >= 0 )
            {
                MoneySuperAlex.Money -= potatoprice ;
                NotEnoghMoney.text = "";
                PotatoSeedsAlex.NoOfSeeds += 1;
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
