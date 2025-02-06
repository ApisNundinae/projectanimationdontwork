using UnityEngine;

public class damagedealer : MonoBehaviour
{

    public int damage;
    public health Health;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Health.TakeDamage(damage);
            Debug.Log("colli");
        }
    }
}
