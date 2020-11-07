using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlantSeedsAlex : MonoBehaviour
{
    public GameObject PlantSeeds;
    public GameObject Alex;
    public GameObject Seed1;
    public GameObject Seed2;
    public GameObject Seed3;
    public GameObject Seed4;
    public GameObject Seed5;
    public GameObject Seed6;
    public GameObject Seed7;
    public GameObject Seed8;
    public GameObject Seed9;
    public GameObject Seed10;
    public GameObject Seed11;
    public GameObject Seed12;
    public GameObject Potato1;
    public float distance;
    
    void Start()
    {
        Seed1.SetActive(false);
        Seed2.SetActive(false);
        Seed3.SetActive(false);
        Seed4.SetActive(false);
        Seed5.SetActive(false);
        Seed6.SetActive(false);
        Seed7.SetActive(false);
        Seed8.SetActive(false);
        Seed9.SetActive(false);
        Seed10.SetActive(false);
        Seed11.SetActive(false);
        Seed12.SetActive(false);
        Potato1.SetActive(false);
    }

    
    void Update()
    {
        distance = Vector2.Distance(PlantSeeds.transform.position, Alex.transform.position);
        if (SeedsTimer.Seed1Grown == true)
        {
            Debug.Log("Potato Placed");
            Potato1.SetActive(true);
        }
        if (distance <= 1 && PotatoSeedsAlex.NoOfSeeds > 0)
        {
            if (Seed1.activeSelf == false)
            {
                Seed1.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                SeedsTimer.Seed1Placed = true;
                return;
            }
            else if (Seed2.activeSelf == false)
            {
                Seed2.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
            else if (Seed3.activeSelf == false)
            {
                Seed3.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
            else if (Seed4.activeSelf == false)
            {
                Seed4.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
            else if (Seed5.activeSelf == false)
            {
                Seed5.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
            else if (Seed6.activeSelf == false)
            {
                Seed6.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
            if (Seed7.activeSelf == false)
            {
                Seed7.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
            else if (Seed8.activeSelf == false)
            {
                Seed8.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
            else if (Seed9.activeSelf == false)
            {
                Seed9.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
            else if (Seed10.activeSelf == false)
            {
                Seed10.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
            else if (Seed11.activeSelf == false)
            {
                Seed11.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
            else if (Seed12.activeSelf == false)
            {
                Seed12.SetActive(true);
                PotatoSeedsAlex.NoOfSeeds -= 1;
                return;
            }
           
        }
    }
}
