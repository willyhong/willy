using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Charactor : MonoBehaviour {

    

    

    [SerializeField]
    private Transform knifePos;

    [SerializeField]
    protected float movementSpeed;

    


    protected bool facingRight;




    [SerializeField]
    private GameObject KinfePrefab;

    

    [SerializeField]
   public Stat healthStat;

    [SerializeField]
    private EdgeCollider2D swordCollider;

    [SerializeField]
    private List<string> demageSources ;

    public abstract bool IsDead { get; }

    public bool Attack { get; set; }
    public bool TakingDemage { get; set; }
    public Animator MyAnimator { get; private set; }

    public EdgeCollider2D SwordCollider
    {
        get
        {
            return swordCollider;
        }

       
    }

    public abstract IEnumerator TakeDemage();


    public virtual void Start ()
    {

        

        facingRight = true;

        MyAnimator = GetComponent<Animator>();
        healthStat.Initialize();
    }


    // Update is called once per frame
    void Update () {
		
	}
    public abstract void Death();

    public virtual void ChangeDirection()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y *1, 1);
    }

    

    public virtual void  ThrowKnife(int value)
    {
        
        if (facingRight)
        {
            GameObject tmp = (GameObject)Instantiate(KinfePrefab, knifePos.position, Quaternion.Euler(new Vector3(0, 0, -90)));
            tmp.GetComponent<Knife>().Initialize(Vector3.right);
        }
        else
        {
            GameObject tmp = (GameObject)Instantiate(KinfePrefab, knifePos.position, Quaternion.Euler(new Vector3(0, 0, 90)));
            tmp.GetComponent<Knife>().Initialize(Vector3.left);
        }
    }

   public void MeleeAttack()
    {
        SwordCollider.enabled = true;
    }

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        if(demageSources.Contains(other.tag))
        {
            StartCoroutine(TakeDemage());
        }
        
    }
}
