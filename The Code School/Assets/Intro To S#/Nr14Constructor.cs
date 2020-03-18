using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr14Constructor : MonoBehaviour
{
    //Använder Nr13ClassesOObejcts!!
    
    // Start is called before the first frame update
    void Start()
    {
        Nr13ClassesOObjects player = new Nr13ClassesOObjects();
        player.Player("Archer", 50f);
        player.Player("Knight", 100f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
