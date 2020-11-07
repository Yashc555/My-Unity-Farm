using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedsTimer : MonoBehaviour
{
    
    public static bool Seed1Placed = false;
    public static bool Seed1Grown = false;
    float TimeForSeed1 = 3f;  

    void Update()
    {
       
        /*if (Seed1Placed == true && TimeForSeed1 > 0)
        {
            
            TimeForSeed1 -= Time.deltaTime;
        }
        if (TimeForSeed1 <= 0)
        {
            Debug.Log("Seed Grown");
            Seed1Placed = false;
            Seed1Grown = true;
            TimeForSeed1 = 30f;
        }*/
    }
    void Seed1()
    {
      
    }

}
/*public static bool Seed2 = false;
    public static bool Seed3 = false;
    public static bool Seed4 = false;
    public static bool Seed5 = false;
    public static bool Seed6 = false;
    public static bool Seed7 = false;
    public static bool Seed8 = false;
    public static bool Seed9 = false;
    public static bool Seed10 = false;
    public static bool Seed11 = false;
    public static bool Seed12 = false;*/
