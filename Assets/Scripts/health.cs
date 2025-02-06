using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class health : MonoBehaviour
{

    public int maxHealth = 3;
    public int Health;
    private hpSystem healthUI;

    void Start()
    {
        Health = maxHealth;
        healthUI = FindAnyObjectByType<hpSystem>();
        healthUI.UpdateHealthUI();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
            Health = 0;

        healthUI.UpdateHealthUI();

        if (Health <= 0)
        {
            //trigger death screen here uwu
            Debug.Log("Player Dead");
        }
    }

    public void getFullHealth()
    {
        print("get full health");
        Health = maxHealth;
        healthUI.UpdateHealthUI();
    }


}
