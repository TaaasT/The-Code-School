using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr8Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CalculateTwoNumbers1();
        CalculateTwoNumbers2(5, 6);
        print("3 The sum of a and b is " + CalculateTwoNumbers3());
        print("4 The sum of a and b is " + CalculateTwoNumbers4(77, 11));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // void does not return a value 
    void CalculateTwoNumbers1()
    {
        print("1 The sum of a and b is" + (3 + 5));
    }
   

        // genom att ha (int a, int b) så måste man "pass in a value" i funktionen för att den ska funka.
        // denna funktion är nu lättare att använda till olika saker. detta går med alla variabler!
    void CalculateTwoNumbers2(int a, int b)
    {
        print("2 The sum of a and b is" + (a + b));
    }
    // retunerar (i detta fall en int. funkar med alla variabler). när jag kallar på metoden så skickar den siffrorna jag lagt in i metoden.
    int CalculateTwoNumbers3()
    {
        return 6 + 7;
    }

    int CalculateTwoNumbers4(int a, int b)
    {
        return a + b;
    }
}
