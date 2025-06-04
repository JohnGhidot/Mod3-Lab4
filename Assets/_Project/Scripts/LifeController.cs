using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class LifeController : MonoBehaviour
{

    [SerializeField] private int health = 50;



    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        
        health -= damage;

        if (health <= 0)
        {
            Debug.Log("Il giocatore è morto!");
            Destroy(gameObject);
        }

        Debug.Log($"Il giocatore ha subito {damage} di danno ed ora ha {health} di salute.");
    }

    public void TakeHeal(int amount)
    {
        health += amount;

        Debug.Log($"Il giocatore ha recuperato {amount} di vita ed ora ha {health} di salute.");
    }

}
