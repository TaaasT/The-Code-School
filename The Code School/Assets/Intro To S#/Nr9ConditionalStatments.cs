using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr9ConditionalStatments : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 6;
        int b = 3;

        // && betyder och. double pipes || = eller
        // man kan ha en if statemets i en if statement. detta kallas för Nesting!!
        if(a < b)// kan åxo bara skiva <= på denna och slippa a == b helt.
        {
            print("A is lower than b");
        }
        else if(a == b)
        {
            print("A is equal than b");
        }
        else if(a > b)
        {
            print("A is greater than b");
        }
        //else {} är att om ingen av övre påståenden är korrekta så bara skiv detta.. därför behöver man inte ().


        // switches funkar med alla variabler! default funkar som else från "if Statements"
        int c = 6;

        switch(c)
        {
            case 1:
                break;
            case 5:
                break;
            case 6:
                print("C is equal to 6");
                break;

            default:
                print("No case is executed, thats why we get default");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
