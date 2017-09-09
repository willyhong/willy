using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour {

    private static GameManager1 instance;
    [SerializeField]
    private GameObject coinPrefab;

    [SerializeField]
    private Text coinTxt;


    private int collectedCoins;

    public static GameManager1 Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager1>();
            }
            return instance;
        }

       
    }

    public GameObject CoinPrefab
    {
        get
        {
            return coinPrefab;
        }

       
    }

    public int CollectedCoins
    {
        get
        {
            return collectedCoins;
        }

        set
        {
            coinTxt.text = value.ToString();
            this.collectedCoins = value;
        }
    }

    
}
