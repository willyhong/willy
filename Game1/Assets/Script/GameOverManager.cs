using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

    public Player0823 playerHealth;
    //public float restartDelay = 5f;



    Animator anim;
    //float restartTimer;

    public void Quit()
    {
        Application.Quit();
    }
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(playerHealth.IsDead == true)
        {
            anim.SetTrigger("GameOver");
            //restartTimer += Time.deltaTime;
            //if(restartTimer >= restartDelay)
            //{
            //    Application.LoadLevel(Application.loadedLevel);
            //}

            if (Input.GetKeyDown(KeyCode.X))
            {
                Application.LoadLevel(0);
            }
        }
		
	}
}
