using UnityEngine;

public class playercombat : MonoBehaviour
{


    public Animator animator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            attack();

        }

        void attack()
        {

            animator.SetTrigger("attackfront");

        }
    }
}
