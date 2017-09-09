using System.Collections;
using UnityEngine;



public delegate void DeadEventHandler();



public class Player0823 : Charactor
{

    private static Player0823 instance;
    private Vector2 startPos;

    public event DeadEventHandler Dead;



   
    [SerializeField]
    private Transform[] GroundCheck;
    [SerializeField]
    private float groundRadius;
    [SerializeField]
    private LayerMask whatIsGround; 
    
    

    [SerializeField]
    private bool airControl;
    [SerializeField]
    private float jumpForce;

    private bool immortal = false;

    private SpriteRenderer spriteRenderer;


    [SerializeField]
    private float immortalTime;

    public Rigidbody2D MyRigiBody { get; set; }
    
    public bool Slide { get; set; }
    public bool Jump { get; set; }
    public bool OnGround { get; set; }

    public static Player0823 Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<Player0823>();
            }
            return instance;
        }


    }


    public override bool IsDead
    {
        get
        {
            if (healthStat.CurrentValue <= 0)
            {
                OnDead();
            }
           return healthStat.CurrentValue <= 0;
        }
    }

    public bool Isfalling
    {
        get
        {
            return MyRigiBody.velocity.y < 0;

        }
    }

    // Use this for initialization
    public override void Start ()
    {       
        base.Start();

        
        startPos = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        MyRigiBody = GetComponent<Rigidbody2D>();
        
       
	}




    private void Update()
    {
        if (!TakingDemage && !IsDead)
        {
            if (transform.position.y <= -14f)
            {
                Death();
            }
            HandleInput();
        }
                   

    }




    // Update is called once per frame
    void FixedUpdate ()
    {
        if (!TakingDemage && !IsDead)
        {
            float horizontal = Input.GetAxis("Horizontal");

            OnGround = IsGrounded();
            
            HandleMovement(horizontal);

            Flip(horizontal);



            HandleLayers();
        }
        
	}

    public void OnDead()
    {
      if(Dead != null)
        {
            Dead();
        }
    }

    private void HandleMovement(float horizontal)
    {
        if (Isfalling)
        {
            gameObject.layer = 11;
            MyAnimator.SetBool("land", true);
        }
        if (!Attack && !Slide && (OnGround || airControl))
        {
            MyRigiBody.velocity = new Vector3(horizontal*movementSpeed, MyRigiBody.velocity.y);
            CheckPlayerPosition();

        }
        if(Jump && MyRigiBody.velocity.y == 0)
        {
            MyRigiBody.AddForce(new Vector3(0, jumpForce));
            CheckPlayerPosition();
        }

        MyAnimator.SetFloat("speed", Mathf.Abs(horizontal));
        CheckPlayerPosition();


    }




   


    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !Isfalling)
        {
            MyAnimator.SetTrigger("jump");
            Jump = true;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            MyAnimator.SetTrigger("attack");
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            MyAnimator.SetTrigger("slide");
        }
    }


    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            ChangeDirection();
        }
    }
    //攻擊時閃爍
    private IEnumerator IndicateImmortal()
    {
        while (immortal)
        {
            spriteRenderer.enabled = false;

            yield return new WaitForSeconds(.1f);

            spriteRenderer.enabled = true;

            yield return new WaitForSeconds(.1f);

        }
    }
    

    private bool IsGrounded()
    {
        if(MyRigiBody.velocity.y <= 0)
        {
            foreach(Transform point in GroundCheck)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius,whatIsGround);

                for(int i=0; i < colliders.Length; i++)
                {
                    if(colliders[i].gameObject != gameObject)
                    {
                        
                        return true;
                    }
                }
            }
        }
        return false;
    }
    private void HandleLayers()
    {
        if (!OnGround)
        {
            MyAnimator.SetLayerWeight(1, 1);
        }
        else
        {
            MyAnimator.SetLayerWeight(1, 0);
        }
    }
    //受到的傷害
    public override IEnumerator TakeDemage()
    {
        if (!immortal)
        {
            healthStat.CurrentValue -= 10;
            if (!IsDead)
            {
                MyAnimator.SetTrigger("demage");
                immortal = true;
                StartCoroutine(IndicateImmortal());
                yield return new WaitForSeconds(immortalTime);

                immortal = false;
            }
            else
            {
                MyAnimator.SetLayerWeight(1, 0);
                MyAnimator.SetTrigger("die");
            }
        }
        
    }

    public override void Death()
    {
         MyRigiBody.velocity = Vector2.zero;
         MyAnimator.SetTrigger("idle");
         healthStat.CurrentValue = (healthStat.MaxVal)-100;
         Destroy(gameObject);

        

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            GameManager1.Instance.CollectedCoins++;
            Destroy(other.gameObject);
            
        }
    }

    private void CheckPlayerPosition()
    {
        //極限值
        Vector3 pos = transform.position;
        float x = pos.x;
        float y = pos.y;
        if(x< -18.02f)
        {
            x = -18.02f;
        }
        if(x> 24.1f)
        {
            x = 24.1f;
        }
        if(y> 12.19f)
        {
            y = 12.19f;
        }
        transform.position = new Vector3(x, y, 0);
    }
}

