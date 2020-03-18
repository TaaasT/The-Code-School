using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr17Inheritance : MonoBehaviour
{
    private void Start()
    {
                
        Nr17 w = new Nr17("Wizard", 34.1f);

        w.Attack();
        w.ReplenishMana(33f);
        w.PlayerInfo();
    }
    
}
