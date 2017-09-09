using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeState : IEnemyState
{

    private float attackTimer;
    private float attackCoolDown = 10;
    private bool canattack = true;
    private Enemy enemy;


    public void Enter(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public void Execute()
    {
        Attack();
        if(enemy.InThrowRange && !enemy.InMeleeRange)
        {
            enemy.ChangeState(new Rangestate());
        }
        else if (enemy.Target == null)
        {
            enemy.ChangeState(new IdleState());
        }

    }

    public void Exit()
    {

    }
    public void OnTriggerEnter(Collider2D other)
    {
        
    }

    private void Attack()
    {
        attackTimer += Time.deltaTime;
        if (attackTimer >= attackCoolDown)
        {
            canattack = true;
            attackTimer = 3;
        }
        if (canattack)
        {
            canattack = false;
            enemy.MyAnimator.SetTrigger("attack");
        }
    }



}
