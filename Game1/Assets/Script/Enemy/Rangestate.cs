using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rangestate : IEnemyState
{

    private Enemy  enemy;
    private float throwTimer;
    private float throwCoolDown = 20;
    private bool canThrow = true;

    public void Enter(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public void Execute()
    {
        ThrowKnife();
        if (enemy.InMeleeRange)
        {
            enemy.ChangeState(new MeleeState());
        }

        if(enemy.Target != null)
        {
            enemy.Move();
        }

        else
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

    private void ThrowKnife()
    {
        throwTimer += Time.deltaTime;
        if(throwTimer >= throwCoolDown)
        {
            canThrow = true;
            throwTimer = 10;
        }
        if (canThrow)
        {
            canThrow = false;
            enemy.MyAnimator.SetTrigger("throw");
        }
    }
    
}
