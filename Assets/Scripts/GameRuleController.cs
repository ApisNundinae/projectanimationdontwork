using System;
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
        enemy.SetItemDropAllowed(false);
        Debug.Log("Item spawning disabled");
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


public class inventory : MonoBehaviour
{
    private List<string> items = new List<string>();

    public void ClearAllItems()
    {
        items.Clear();
        Debug.Log("Inventory cleared");
    }
}

public class itemSpawner : MonoBehaviour
{
    private bool spawnAllowed = true;

public void DisableItemDrops()
    {
        enemy.SetItemDropAllowed(false);
        Debug.Log("drop item disabled");
    }

    public void EnableItemDrops()
    {
        enemy.SetItemDropAllowed(true);
        Debug.Log("drop item enabled");
    }
}
