using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorler : MonoBehaviour {
    Animator _anim;
    public float MoveSpeed = 5f;
    public float JumpPower = 400f;
    private Rigidbody2D m_Rigibody2D;
    Vector3 Start_Scale;
    bool jump = false;
    // Use this for initialization
    void Start () {
        _anim = GetComponent<Animator>();
        Start_Scale = transform.localScale;
        m_Rigibody2D = GetComponent<Rigidbody2D>();
		
	}
	
    


	// Update is called once per frame
	void Update () {    





        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            _anim.SetBool("Move", true);
            float xx = Input.GetAxisRaw("Horizontal");
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.localScale = new Vector3(Start_Scale.x, Start_Scale.y, Start_Scale.z);
                transform.Translate(Vector3.right * xx * MoveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.localScale = new Vector3(-Start_Scale.x, Start_Scale.y, Start_Scale.z);
                transform.Translate(Vector3.right * xx * MoveSpeed * Time.deltaTime);
            }
        }
        else
        {
            _anim.SetBool("Move", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigibody2D.AddForce(new Vector2(0.3f, JumpPower));
        }
        if (Input.GetKey(KeyCode.A))
        {
            _anim.SetTrigger("Fight");
        }
		
	}
}
