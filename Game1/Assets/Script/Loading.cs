using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("WaitAndGo", 2);
	}
    void WaitAndGo()
    {
#pragma warning disable CS0618 // 類型或成員已經過時
        Application.LoadLevel(2);
#pragma warning restore CS0618 // 類型或成員已經過時
    }



}
