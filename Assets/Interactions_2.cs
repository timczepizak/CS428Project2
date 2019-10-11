using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions_2 : MonoBehaviour
{
    public GameObject Rock;

    public void FallDown()
    {
        Debug.Log("YOU TOUCHED ME");
        Rock.GetComponent<Rigidbody>().freezeRotation = true;
        Rock.GetComponent<Animator>().SetBool("Fall", true);
        Destroy(Rock, .75f);
    }
}
