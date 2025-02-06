using UnityEngine;

public class playerdamagedealer : MonoBehaviour
{

    public int damage;
    public health Health;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hit")
        {

            Health.TakeDamage(damage);
            Debug.Log("colli");
        }
    }
}
