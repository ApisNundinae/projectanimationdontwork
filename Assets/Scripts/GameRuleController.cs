using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameRuleController : MonoBehaviour
{
    public static GameRuleController instance;
    private PlayerController player;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        player = FindAnyObjectByType<PlayerController>();
    }

    public void ReversePlayerControls()
    {
        if (player != null)
        {
            player.ReverseControls();
        }
    }

    public void ReducePlayerSpeed()
    {
        if (player != null)
        {
            player.ModifySpeed(0.5f);
        }
    }

    public void FogMode()
    {
        FindAnyObjectByType<fogSystem>().SetFog(true);
    }

    public void IncreaseEnemySpeed()
    {
        FindAnyObjectByType<enemy>().MultiplySpeed(2.5f);
    }

    public void DisableItemSpawning()
    {
        FindAnyObjectByType<itemSpawner>().StopSpawning();
    }

    public void ClearInventory()
    {
        FindAnyObjectByType<inventory>().ClearAllItems();
    }
}


public class fogSystem : MonoBehaviour
{
    public GameObject fog;

    public void SetFog(bool active)
    {
        fog.SetActive(active);
    }
}

public class enemy : MonoBehaviour
{
    private float speed = 5.0f;

    public void MultiplySpeed(float multiplier)
    {
        speed *= multiplier;
    }
}

public class itemSpawner : MonoBehaviour
{
    private bool spawnAllowed = true;

    void Update()
    {
        if (spawnAllowed)
        {
            // Spawn items but how ?? 
        }
    }

    public void StopSpawning()
    {
        spawnAllowed = false;
    }
}

public class inventory : MonoBehaviour
{
    private List<string> items = new List<string>();

    public void ClearAllItems()
    {
        items.Clear();
        Debug.Log("Inventory cleared");
    }
}