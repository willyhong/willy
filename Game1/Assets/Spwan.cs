using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwan : MonoBehaviour {
    public GameObject Enemy;
    public float EnemyRate = 5f;//生成敵人的速度


	// Use this for initialization
	void Start () {
        InvokeRepeating("creatEnemy", 3, EnemyRate);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void creatEnemy()

    {
        float x = Random.Range(-19.24f, 23.27f);
        GameObject.Instantiate(Enemy, new Vector3(x,transform.position.y,0), Quaternion.identity);
    }
}
