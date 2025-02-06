using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject[] itemDrops;
    public float dropChance = 0.5f;

    private static bool itemDropAllowed = true;

    public static void SetItemDropAllowed(bool allowed)
    {
        itemDropAllowed = allowed;
    }

    public void TakeDamage(int damage)
    {
        int health = 10;
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        DropItem();
        Destroy(gameObject);
    }

    void DropItem()
    {
        if (!itemDropAllowed) return;

        if (itemDrops.Length > 0 && Random.value < dropChance)
        {
            int randomIndex = Random.Range(0, itemDrops.Length);
            Vector3 dropPosition = transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);

            Instantiate(itemDrops[randomIndex], dropPosition, Quaternion.identity);
        }
    }

    public float speed = 5.0f;

    public void MultiplySpeed(float multiplier)
    {
        speed *= multiplier;
        Debug.Log("Enemy speed multiplied by " + multiplier);
    }
}