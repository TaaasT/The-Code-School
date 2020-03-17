using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr11Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // arrays gör man istället för att deklaraera flera int/float/double
        int[] data = new int[10];
        
        // data.length är alltid sista nummret i din array. smidigare att använda det data.length fall i fall du skulle ändra längden.
        for(int i = 0; i < data.Length; i++)
        {
            data[i] = Random.Range(0, 100);
            //print("The element at index" + i + "has a value of " + data[i]);
        }
        
        foreach(int num in data)
        {
            print("The value of the element is " + num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
