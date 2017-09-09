using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour {




    

    [SerializeField]
    private BoxCollider2D platfromCollider;

    [SerializeField]
    private BoxCollider2D platformTrigger;

	void Start () {
        

        Physics2D.IgnoreCollision(platfromCollider, platformTrigger, true);
	}

     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag =="Enemy")
        {
            Physics2D.IgnoreCollision(platfromCollider, other, true);
        }
    }

     void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(platfromCollider, other, false);
        }
    }
}
