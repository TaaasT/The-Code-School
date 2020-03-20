using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr20Coroutines : MonoBehaviour
{
    // måste skapa en metod (IEnumerator) sen kalla på den med StartCoroutine
    void Start()
    {
        StartCoroutine(PrintAfterDelay());
    }

    IEnumerator PrintAfterDelay()
    {
        print("direkt");
        yield return new WaitForSeconds(2f);
        print("Hellooo");
    }
}
