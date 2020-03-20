using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr21Delegates : MonoBehaviour
{

    // hela grejen e att detta ska va i en script som inheritar
    public delegate void PlayerDied();
    public static event PlayerDied playerDied;


    void Start()
    {
        if (playerDied != null)
        {
            playerDied();
        }
    }

    private void OnEnable()
    {
        playerDied += ExecutedAfterEventCall;
    }

    private void OnDisable()
    {
        playerDied -= ExecutedAfterEventCall;
    }

    void ExecutedAfterEventCall()
    {
        print("Prited after event was calld");
    }
    
}
