using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr16VisibilityModifiers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Nr16 knight = new Nr16("knight", 1);

        knight.Health = 3f;

        knight.PlayerInfo();





        /* Detta e 1:a sätt att göra det på 
        knight.SetHealth(3.4f);
        print(knight.GetHealth());
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
