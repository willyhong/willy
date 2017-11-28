using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.X))
        {
#pragma warning disable CS0618 // 類型或成員已經過時
            Application.LoadLevel(1);
#pragma warning restore CS0618 // 類型或成員已經過時
        }
	}
}
