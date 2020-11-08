using System.Collections;
using UnityEngine;

public class PlantSeedsAlex : MonoBehaviour
{
    
    public GameObject PlantSeeds;

    public GameObject HarvestSeeds;

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
    public GameObject[] Seeds = new GameObject[12];
                            
    public GameObject Potato1;
    public GameObject Potato2;
    public GameObject Potato3;
    public GameObject Potato4;
    public GameObject Potato5;
    public GameObject Potato6;
    public GameObject Potato7;
    public GameObject Potato8;
    public GameObject Potato9;
    public GameObject Potato10;
    public GameObject Potato11;
    public GameObject Potato12;
                            
    public static bool Seed1Placed = false;
    public static bool Seed2Placed = false;
    public static bool Seed3Placed = false;
    public static bool Seed4Placed = false;
    public static bool Seed5Placed = false;
    public static bool Seed6Placed = false;
    public static bool Seed7Placed = false;
    public static bool Seed8Placed = false;
    public static bool Seed9Placed = false;
    public static bool Seed10Placed = false;
    public static bool Seed11Placed = false;
    public static bool Seed12Placed = false;
                            
    public float DistancePlantSeeds;
                            
    public float DistanceHarvestSeeds;
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
        Potato2.SetActive(false);
        Potato3.SetActive(false);
        Potato4.SetActive(false);
        Potato5.SetActive(false);
        Potato6.SetActive(false);
        Potato7.SetActive(false);
        Potato8.SetActive(false);
        Potato9.SetActive(false);
        Potato10.SetActive(false);
        Potato11.SetActive(false);
        Potato12.SetActive(false);
        
    }                       
                            
                            
    void Update()           
    {                       
        DistancePlantSeeds = Vector2.Distance(PlantSeeds.transform.position, Alex.transform.position);
                            
        DistanceHarvestSeeds = Vector2.Distance(HarvestSeeds.transform.position, Alex.transform.position);
                            
        if (DistanceHarvestSeeds < 1)
        {                   
            if (Seed1Placed) {
                Potato1.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed1Placed = false;
            }               
            if (Seed2Placed)
            {               
                Potato2.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed2Placed = false;
            }               
            if (Seed3Placed)
            {               
                Potato3.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed3Placed = false;
            }               
            if (Seed4Placed)
            {               
                Potato4.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed4Placed = false;
            }               
            if (Seed5Placed) {
                Potato5.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed5Placed = false;
            }               
            if (Seed6Placed)
            {               
                Potato6.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed6Placed = false;
            }               
            if (Seed7Placed)
            {               
                Potato7.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed7Placed = false;
            }               
            if (Seed8Placed)
            {               
                Potato8.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed8Placed = false;
            }               
            if (Seed9Placed)
            {               
                Potato9.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed9Placed = false;
            }               
            if (Seed10Placed)
            {               
                Potato10.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed10Placed = false;
            }               
            if (Seed11Placed)
            {               
                Potato11.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed11Placed = false;
            }               
            if (Seed12Placed)
            {               
                Potato12.SetActive(false);
                MoneySuperAlex.Money += 10;
                Seed12Placed = false;
            }               
                            
        }                   
                            
        if (DistancePlantSeeds <= 1 && PotatosAlex.NoOfSeeds > 0)
        {                   
            if (Seed1.activeSelf == false)
            {               
                Seed1.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed1Timer());
                return;     
            }               
            else if (Seed2.activeSelf == false)
            {               
                Seed2.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed2Timer());
                return;     
            }               
            else if (Seed3.activeSelf == false)
            {               
                Seed3.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed3Timer());
                return;     
            }               
            else if (Seed4.activeSelf == false)
            {               
                Seed4.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed4Timer());
                return;     
            }               
            else if (Seed5.activeSelf == false)
            {               
                Seed5.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed5Timer());
                return;     
            }               
            else if (Seed6.activeSelf == false)
            {               
                Seed6.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed6Timer());
                return;     
            }               
            if (Seed7.activeSelf == false)
            {               
                Seed7.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed7Timer());
                return;     
            }               
            else if (Seed8.activeSelf == false)
            {               
                Seed8.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed8Timer());
                return;     
            }               
            else if (Seed9.activeSelf == false)
            {               
                Seed9.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed9Timer());
                return;     
            }               
            else if (Seed10.activeSelf == false)
            {               
                Seed10.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed10Timer());
                return;     
            }               
            else if (Seed11.activeSelf == false)
            {               
                Seed11.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed11Timer());
                return;     
            }               
            else if (Seed12.activeSelf == false)
            {               
                Seed12.SetActive(true);
                PotatosAlex.NoOfSeeds -= 1;
                StartCoroutine(Seed12Timer());
                return;     
            }               
                            
        }                   
    }                       
    IEnumerator Seed1Timer()
    {                       
        yield return new WaitForSeconds(10.0f);
        Potato1.SetActive(true);
        Seed1.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
                            
        Seed1Placed = true; 
    }                       
    IEnumerator Seed2Timer()
    {                       
        yield return new WaitForSeconds(10.0f);
        Potato2.SetActive(true);
        Seed2.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
                            
        Seed2Placed = true; 
    }                       
    IEnumerator Seed3Timer()
    {                       
        yield return new WaitForSeconds(10.0f);
        Potato3.SetActive(true);
        Seed3.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
                            
        Seed3Placed = true; 
    }                       
    IEnumerator Seed4Timer()
    {                       
        yield return new WaitForSeconds(10.0f);
        Potato4.SetActive(true);
        Seed4.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
                            
        Seed4Placed = true; 
    }                       
    IEnumerator Seed5Timer()
    {                       
        yield return new WaitForSeconds(10.0f);
        Potato5.SetActive(true);
        Seed5.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
                            
        Seed5Placed = true; 
    }                       
    IEnumerator Seed6Timer()
    {                       
        yield return new WaitForSeconds(10.0f);
        Potato6.SetActive(true);
        Seed6.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
                            
        Seed6Placed = true; 
    }                       
    IEnumerator Seed7Timer()
    {                       
        yield return new WaitForSeconds(10.0f);
        Potato7.SetActive(true);
        Seed7.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
        
        Seed7Placed = true;
    }
    IEnumerator Seed8Timer()
    {
        yield return new WaitForSeconds(10.0f);
        Potato8.SetActive(true);
        Seed8.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
        
        Seed8Placed = true;
    }
    IEnumerator Seed9Timer()
    {
        yield return new WaitForSeconds(10.0f);
        Potato9.SetActive(true);
        Seed9.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
        
        Seed9Placed = true;
    }
    IEnumerator Seed10Timer()
    {
        yield return new WaitForSeconds(10.0f);
        Potato10.SetActive(true);
        Seed10.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
        
        Seed10Placed = true;
    }
    IEnumerator Seed11Timer()
    {
        yield return new WaitForSeconds(10.0f);
        Potato11.SetActive(true);
        Seed11.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
        
        Seed11Placed = true;
    }
    IEnumerator Seed12Timer()
    {
        yield return new WaitForSeconds(10.0f);
        Potato12.SetActive(true);
        Seed12.SetActive(false);
        PotatosAlex.NoOfPotatoesHarvested += 1;
        
        Seed12Placed = true;
    }
}

