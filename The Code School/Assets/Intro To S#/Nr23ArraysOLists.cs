using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr23ArraysOLists : MonoBehaviour
{
    //Arrays är fixed nummer.. som nu har vi bara 10 slots.. inte mindre inte mer
    int[] things = new int[10];


    //Lists är smidigare.. kan lägga till hur många jag behöver
    public List<int> items;


    // för att lägga till en plats i en list.
    void Start()
    {
        items.Add(1);

        items.Remove(1);

        for(int i = 0; i < items.Count; i++)
        {
            items[i] = 3;
        }
    }

    
}
