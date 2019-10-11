using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleControl : MonoBehaviour
{
    public GameObject Candle;
    public void CandleFall()
    {
        Debug.Log("YOU TOUCHED ME");
        Candle.GetComponent<Rigidbody>().freezeRotation = true;
        Candle.GetComponent<Animator>().SetBool("DropCandle", true);


    }
}
