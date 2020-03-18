using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr13Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // vi har skapat Nr13ClassesOObjects där vi tagit bort monobehavior och kallar den i raden under o kan nu använda den.
        // Nr13ClassOObjects är nu en mall. vi kan använda den flera gånger bara ge den ett nytt namn.. tex
        Nr13ClassesOObjects wizard = new Nr13ClassesOObjects();
        wizard.PlayerInfo();

        Nr13ClassesOObjects Knight = new Nr13ClassesOObjects();
        Knight.name = "Knight";
        Knight.health = 64f;
        Knight.PlayerInfo();

        Nr13ClassesOObjects archer = new Nr13ClassesOObjects();
        archer.name = "Archer";
        archer.health = 44f;
        archer.PlayerInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
