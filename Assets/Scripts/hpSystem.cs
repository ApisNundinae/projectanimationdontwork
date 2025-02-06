using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpSystem : MonoBehaviour
{
    public Image heartImage;
    public Sprite threeHearts;
    public Sprite twoHearts;
    public Sprite oneHeart;

    public GameObject hearts1, hearts2, hearts3;

    private health playerHealth;

    void Awake()
    {
        playerHealth = FindAnyObjectByType<health>();
    }

    void Start()
    {
        if (playerHealth != null)
        {
            UpdateHealthUI();
        }
    }
    public void UpdateHealthUI()
    {
        if (playerHealth == null) // 🔥 `null` 체크 추가
        {
            Debug.LogError("⚠ `playerHealth`가 null입니다! `health`가 씬에 로드되었는지 확인하세요.");
            return;
        }


        switch (playerHealth.Health)
        {
            case 3:
                hearts1.SetActive(true);    
                hearts2.SetActive(true);    
                hearts3.SetActive(true);    
                break;
            case 2:
                hearts1.SetActive(true);    
                hearts2.SetActive(true);    
                hearts3.SetActive(false);  
                break;
            case 1:
                hearts1.SetActive(true);    
                hearts2.SetActive(false);    
                hearts3.SetActive(false);  
                break;
        }
    }
}
