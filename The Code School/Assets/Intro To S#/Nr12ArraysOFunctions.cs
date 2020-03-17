using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr12ArraysOFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] data = new int[10];

        ProccesArray(data);
    }

    void ProccesArray(int[] data)
    {
        for(int i = 0; i < data.Length; i++)
        {
            data[i] = Random.Range(0, 100);
            print("The value is " + data[i]);
        }
    }
}
