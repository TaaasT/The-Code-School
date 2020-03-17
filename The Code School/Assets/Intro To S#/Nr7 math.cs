using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr7math : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Casta är när man har en float men vill göra det till en int tex. (int) 1f; // behövs inte göras från int till float/double.

        int a = 5;
        int b = 6;

        // detta går med +, - och * MEN inte / pga då måste det vara en float!!
        int sum = a + b; // kan åxo skriva siffror direkt om vi inte vill deklarera variabler men bättre att deklarera
        float summ = (2 + 3) * (4 - (4 / 3));

        // för att detta ska prinats i consolen behövs en gameobject i Unity. såhär för att printa string o siffror.
        print("the sum of a and b is " + sum);
        print(summ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
