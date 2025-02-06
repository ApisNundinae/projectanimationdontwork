using UnityEngine;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{
    public static List<enemy> enemies = new List<enemy>();

    public static void RegisterEnemy(enemy e)
    {
        enemies.Add(e);
    }

    public static void IncreaseAllEnemySpeeds(float multiplier)
    {
        foreach (var e in enemies)
        {
            e.MultiplySpeed(multiplier);
        }
    }
}
