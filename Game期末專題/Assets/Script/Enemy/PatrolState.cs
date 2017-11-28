﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : IEnemyState
{

    private Enemy enemy;
    private float patrolTimer;
    private float patrolDuration;


    public void Enter(Enemy enemy)
    {
        patrolDuration = UnityEngine.Random.Range(1, 10);
        this.enemy = enemy;
    }

    public void Execute()
    {
       
        Patrol();


        enemy.Move();
        if(enemy.Target != null && enemy.InThrowRange)
        {
            enemy.ChangeState(new Rangestate());
        }

    }

    public void Exit()
    {
        
    }

    public void OnTriggerEnter(Collider2D other)
    {
       if(other.tag == "Edge")
        {
            enemy.ChangeDirection();
        }
        if (other.tag == "Knife")
        {
            enemy.Target = Player0823.Instance.gameObject;
        }
    }


    private void Patrol()
    {
        
        patrolTimer += Time.deltaTime;
        if (patrolTimer >= patrolDuration)
        {
            enemy.ChangeState(new IdleState());
        }
    }
}
