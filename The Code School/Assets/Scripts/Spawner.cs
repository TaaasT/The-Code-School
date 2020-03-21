using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bomb;

    float minX = -2.55f;
    float maxX = 2.55f;

    void Start()
    {
        StartCoroutine(SpawnBombs());
    }

    IEnumerator SpawnBombs()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        Instantiate(bomb, new Vector2(Random.Range(minX, maxX), transform.position.y),
            Quaternion.identity);

        StartCoroutine(SpawnBombs());
    }
}
