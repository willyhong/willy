using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelScroll : MonoBehaviour, IBeginDragHandler,IEndDragHandler
{
    private ScrollRect scrollrect;
    public float smoothing = 5;//移動速度
    public Toggle[] toggleArray;
    private float[] pageArray = new float[] { 0, 0.414f, 0.83f,1.085f };//每一頁的起始點
    private float targetHorizontoalPosition = 0;
    private bool isDraging = false; 
    void Start () {
        scrollrect = GetComponent<ScrollRect>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isDraging == false)
        {
            scrollrect.horizontalNormalizedPosition = Mathf.Lerp(scrollrect.horizontalNormalizedPosition, targetHorizontoalPosition,
                Time.deltaTime * smoothing);//緩動滑動換頁
        }
	}

    //拖動起始點與結束點
    public void OnBeginDrag(PointerEventData eventData)
    {
        isDraging = true;
    }

    public void OnEndDrag(PointerEventData eventData)//拖曳結束時發生
    {
        isDraging = false;
       float temp = scrollrect.horizontalNormalizedPosition;//取得拖曳結尾的座標
        int index = 0;//預設頁碼
        float offset = Math.Abs(pageArray[index] - temp);//差值運算(取絕對值)
        for(int i = 1;i<pageArray.Length;i++)
        {
            float offsettemp = Math.Abs(pageArray[i] - temp);//幫你做出來的點
            if(offsettemp < offset)
            {
                index = i;
                offset = offsettemp;//實現跳頁(離 Array點靠近的那頁)
            }
        }
        targetHorizontoalPosition = pageArray[index];
        toggleArray[index].isOn = true;//樹葉跟著頁面跳動
        //scrollrect.horizontalNormalizedPosition = pageArray[index];
       

    }
    public void TurntoPage1(bool isOn)
    {
        targetHorizontoalPosition = pageArray[0];//跳到第一頁
    }
    public void TurntoPage2(bool isOn)
    {
        targetHorizontoalPosition = pageArray[1];//跳到第2頁
    }
    public void TurntoPage3(bool isOn)
    {
        targetHorizontoalPosition = pageArray[2];//跳到第3頁
    }
    public void TurntoPage4(bool isOn)
    {
        targetHorizontoalPosition = pageArray[3];//跳到第4頁
    }
}
