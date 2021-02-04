using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCoin : MonoBehaviour
{
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            if (other.gameObject.name.Contains("CoinSprite"))
                _gameManager.currentPoints++;
            else if (other.gameObject.name.Contains("MarioCoin"))
                _gameManager.currentPoints += 2;
            else if (other.gameObject.name.Contains("BigCoin"))
                _gameManager.currentPoints += 3;

            Destroy(other.gameObject);
        }
    } 
}
