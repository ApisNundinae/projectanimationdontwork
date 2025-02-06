using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZoneController : MonoBehaviour
{
    public UnityEvent eventToTriggerWhenEnter, eventToTriggerWhenExit, eventToTriggerWhenStaying;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            eventToTriggerWhenEnter.Invoke();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            eventToTriggerWhenExit.Invoke();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            eventToTriggerWhenStaying.Invoke();
        }
    }
}
