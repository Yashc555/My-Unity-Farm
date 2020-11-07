using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarwinPlantSeeds : MonoBehaviour
{
    public GameObject PlantSeeds;
    public GameObject Darwin;
    public GameObject Seed1;
    public GameObject Seed2;
    public GameObject Seed3;
    public GameObject Seed4;
    public GameObject Seed5;
    public GameObject Seed6;
    public float distance;
    
    void Start()
    {
        Seed1.SetActive(false);
        Seed2.SetActive(false);
        Seed3.SetActive(false);
        Seed4.SetActive(false);
        Seed5.SetActive(false);
        Seed6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(PlantSeeds.transform.position, Darwin.transform.position);
        if (distance <= 4 && PotatoSeedsDarwin.NoOfSeeds > 0)
        {

            
            if (Seed1.activeSelf == false)
            {
                Seed1.SetActive(true);
                PotatoSeedsDarwin.NoOfSeeds -= 1;
                Debug.Log("Seeds Planted");
                return;
            }
            else if (Seed2.activeSelf == false)
            {
                Seed2.SetActive(true);
                PotatoSeedsDarwin.NoOfSeeds -= 1;
                Debug.Log("Seeds Planted");
                return;
            }
            else if (Seed3.activeSelf == false)
            {
                Seed3.SetActive(true);
                PotatoSeedsDarwin.NoOfSeeds -= 1;
                Debug.Log("Seeds Planted");
                return;
            }
            else if (Seed4.activeSelf == false)
            {
                Seed4.SetActive(true);
                PotatoSeedsDarwin.NoOfSeeds -= 1;
                Debug.Log("Seeds Planted");
                return;
            }
            else if (Seed5.activeSelf == false)
            {
                Seed5.SetActive(true);
                PotatoSeedsDarwin.NoOfSeeds -= 1;
                Debug.Log("Seeds Planted");
                return;
            }
            else if (Seed6.activeSelf == false)
            {
                Seed6.SetActive(true);
                PotatoSeedsDarwin.NoOfSeeds -= 1;
                Debug.Log("Seeds Planted");
                return;
            }

        }
    }
}
