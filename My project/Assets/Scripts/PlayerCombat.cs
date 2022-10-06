using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        //Correr la aniamcion del ataque
        animator.SetTrigger("Attack");
        //Detectar los enemigos en rango del ataque
        //Hacerle daño a los enemigos
    }


}
