using UnityEngine;

public class bossscript : MonoBehaviour
{
    private Animator Animator;
    private float IdleTimer = 2f;
    private float timer;

    void Start()
    {
        Animator = GetComponent<Animator>();   
        timer = IdleTimer ;
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            RandomAttack();
            timer = IdleTimer;

        }

    }

    void RandomAttack()
    {
        int attack = Random.Range(0, 4);
        Animator.SetTrigger("Attack" + attack);

    }
}
