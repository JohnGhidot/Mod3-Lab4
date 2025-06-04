using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    private static int coins = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            coins++;
            Debug.Log($"Monete raccolte: {coins}");
            Destroy(gameObject);
        }


    }
}
