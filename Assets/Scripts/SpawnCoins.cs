using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class SpawnCoins : MonoBehaviour
{
    public Transform[] coinSpawns;
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < coinSpawns.Length; i++)
        {
            float coinFlip = Random.Range(0f, 2f);
            if (coinFlip>0)
            {
                Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
            }
        }
    }
}
