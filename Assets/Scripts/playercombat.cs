using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack();
        }
    }

    void attack()
    {

        animator.SetTrigger("attack");

    }
}