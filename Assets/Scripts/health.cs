using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class health : MonoBehaviour
{

    public int maxHealth = 3;
    public int Health;
    void Start()
    {
        Health = maxHealth;
    }

    public void TakeDamage(int damage)
    {

        Health -= damage;
        if (Health <= 0)
        {
            //trigger death screen here uwu
            Debug.Log("yes");

        }
    }

    public void getFullHealth()
    {
        print("get full healyh");
        Health = maxHealth;
    }


}
