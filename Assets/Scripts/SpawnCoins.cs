using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class SpawnCoins : MonoBehaviour
{
    public Transform[] coinSpawns;
    public GameObject[] coins;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        foreach (var coinSpawn in coinSpawns)
        {
            var coinSelect = Random.Range(0, coins.Length);
            var coin = coins[coinSelect];
            Instantiate(coin,coinSpawn.transform.position,Quaternion.identity);
        }
    }
}
