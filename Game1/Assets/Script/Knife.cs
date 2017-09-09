using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof( Rigidbody2D))]
public class Knife : MonoBehaviour {
    [SerializeField]
    private float speed;

    private Rigidbody2D myRigiBody;

    private Vector2 direction;
	// Use this for initialization
	void Start () {
        myRigiBody = GetComponent<Rigidbody2D>();
       // direction = Vector2.right;
        
	}



    private void FixedUpdate()
    {
        myRigiBody.velocity = direction * speed;
    }

    public void Initialize(Vector2 direction)
    {
        this.direction = direction;
    }



    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }




}
