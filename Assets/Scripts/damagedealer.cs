using UnityEngine;

public class damagedealer : MonoBehaviour
{
    
    public int damage;
    public health Health;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Health.TakeDamage(damage);
            Debug.Log("colli");
        }
    }
}
