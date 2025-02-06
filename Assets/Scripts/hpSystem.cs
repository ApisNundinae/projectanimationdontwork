using System.Collections.Generic;
using UnityEngine;

public class hpSystem : MonoBehaviour
{
    public List<GameObject> hearts;
    private health playerHealth;

    void Start()
    {
        playerHealth = FindObjectOfType<health>();
        UpdateHealthUI();
    }

    public void UpdateHealthUI()
    {
        for (int i = 0; i < hearts.Count; i++)
        {
            if (i < playerHealth.Health)
                hearts[i].SetActive(true);

            else
                hearts[i].SetActive(false);
        }
    }
}
