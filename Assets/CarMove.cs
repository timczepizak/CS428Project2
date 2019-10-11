using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public GameObject Car;

    public void DriveCar()
    {
        Debug.Log("YOU TOUCHED ME");
        Car.GetComponent<Rigidbody>().freezeRotation = true;
        Car.GetComponent<Animator>().SetBool("Drive", true);
        Car.GetComponent<Animator>().SetBool("DontDrive", false);
    }
}
