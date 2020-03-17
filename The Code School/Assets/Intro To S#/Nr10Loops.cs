using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr10Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // GÄLLER ALLA!! dom måste bli falska någon gång annars körs koden för alltid och programmet kommer crasha!


        for(int i = 0; i < 10; i++) // i++ är samma som att skriva i = 1 + 1
        {
            print("The value of i is" + i);
        }

        int o = 0;

        // så detta e samma som ovan fast ett annat sätt att skriva det.
        while (o < 10)
        {
            print("The value of i is" + o);
            o++;
        }

        int y = 0;
        // do loop utför koden först sen kollar om conditionen stämmer. alla andra kollar först sen kör koden
        do
        {
            print("The value of i is" + y);
        } while (y < 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
