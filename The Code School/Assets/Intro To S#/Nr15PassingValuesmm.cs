using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr15PassingValuesmm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Nr13ClassesOObjects Knight = new Nr13ClassesOObjects("Knight", 1);

        Knight.PlayerInfo();

        print("/n");
        ChangePlayer(Knight);

        Knight.PlayerInfo();

    }

    void ChangePlayer(Nr13ClassesOObjects p)
    {
        p.name = "change the name in the function";
    }
}
