using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpSystem : MonoBehaviour
{
    public Image heartImage;
    public Sprite threeHearts;
    public Sprite twoHearts;
    public Sprite oneHeart;

    private health playerHealth;

    void Start()
    {
        playerHealth = FindAnyObjectByType<health>();
        UpdateHealthUI();
    }

    public void UpdateHealthUI()
    {
        switch (playerHealth.Health)
        {
            case 3:
                heartImage.sprite = threeHearts;
                break;
            case 2:
                heartImage.sprite = twoHearts;
                break;
            case 1:
                heartImage.sprite = oneHeart;
                break;
        }
    }
}
