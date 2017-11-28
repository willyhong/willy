using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Charactor {




    private IEnemyState currentState;
	

    public GameObject Target { get; set; }
    [SerializeField]
    private float meleeRange;

    [SerializeField]
    private float throwRange;
    [SerializeField]
    private Transform leftEdge;
    [SerializeField]
    private Transform RightEdge;

    private Canvas healthCanvas;



    private bool dropItem = true;







    public bool InMeleeRange
    {
        get
        {
            if(Target != null)
            {
                return Vector3.Distance(transform.position, Target.transform.position) <= meleeRange ;
            }
            return false;
        }

    }

    public bool InThrowRange
    {
        get
        {
            if (Target != null)
            {
                return Vector3.Distance(transform.position, Target.transform.position) <= throwRange;
            }
            return false;
        }

    }

    public override bool IsDead
    {
        get
        {
            return healthStat.CurrentValue <= 0;
        }
    }

    public override void Start ()
    {
        base.Start();
        this.startPos = transform.position;
        Player0823.Instance.Dead += new DeadEventHandler(RemoveTarget);
        ChangeState(new IdleState());

        healthCanvas = transform.GetComponentInChildren<Canvas>();
	}
	
	
	void Update ()
    {
        if (!IsDead)
        {
            if (!TakingDemage)
            {
                currentState.Execute();
               
            }
            LookAtTarget();
        }
	}

    private void RemoveTarget()
    {
        Target = null;
        ChangeState(new PatrolState());
    }

    private void LookAtTarget()
    {
        if (Target != null)
        {
            float xDir = Target.transform.position.x - transform.position.x;

            if (xDir < 0 && facingRight || xDir > 0 && !facingRight)
            {
                ChangeDirection();
            }
        }
    }


    public override void ChangeDirection()
    {
        //Makes a reference to the enemys canvas
        Transform tmp = transform.Find("EnemyHealthCanvas").transform;

        //Stores the position, so that we know where to move it after we have flipped the enemy
        Vector3 pos = tmp.position;

        ///Removes the canvas from the enemy, so that the health bar doesn't flip with it
        tmp.SetParent(null);

        ///Changes the enemys direction
        base.ChangeDirection();

        //Puts the health bar back on the enemy.
        tmp.SetParent(transform);

        //Pits the health bar back in the correct position.
        tmp.position = pos;
    }





    public void ChangeState(IEnemyState newState)
    {
        if(currentState != null)
        {
            currentState.Exit();
        }

        currentState = newState;
        currentState.Enter(this);
    }


    public void Move()
    {
        if (!Attack)
        {
            if ((GetDirection().x > 0 && transform.position.x < RightEdge.position.x)||(GetDirection().x < 0 && transform.position.x > leftEdge.position.x))
            {
                MyAnimator.SetFloat("speed", 1);
                transform.Translate(GetDirection() * (movementSpeed * Time.deltaTime));
            }
        }
        else if(currentState is PatrolState)
        {
            ChangeDirection();
        }
        else if (currentState is Rangestate)
        {
            Target = null;
            ChangeState(new IdleState());
        }
    }


    


    public Vector2 GetDirection()
    {
        return facingRight ? Vector2.right : Vector2.left;
    }

    public  override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        currentState.OnTriggerEnter(other);
    }

    public override IEnumerator TakeDemage()
    {
        if (!healthCanvas.isActiveAndEnabled)
        {
            healthCanvas.enabled = true;
        }
        healthStat.CurrentValue -= 10;

        if (!IsDead)
        {
            MyAnimator.SetTrigger("demage");
        }
        else
        {
            if (dropItem)
            {
                //GameObject coin = (GameObject)Instantiate(GameManager1.Instance.CoinPrefab, new Vector3(transform.position.x, transform.position.y + 2), Quaternion.identity);
                //Physics2D.IgnoreCollision(coin.GetComponent<Collider2D>(), GetComponent<Collider2D>());
                dropItem = false;
                //MyAnimator.SetTrigger("die");f
            }
            MyAnimator.SetTrigger("die");
            yield return null;
        }
        

    }
    private Vector2 startPos;


    public override void Death()
    {
        dropItem = true;
        Instantiate(GameManager1.Instance.CoinPrefab, new Vector3(transform.position.x, transform.position.y + 2), Quaternion.identity);
        MyAnimator.ResetTrigger("die");
        MyAnimator.SetTrigger("idle");
        healthStat.CurrentValue = healthStat.MaxVal;
        transform.position = startPos;
        healthCanvas.enabled = false;


        //Destroy(gameObject);

    }
}
