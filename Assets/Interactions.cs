using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{

    public GameObject Rocket;
    public ParticleSystem RocketParticleSystem;
    public ParticleSystem Pop;

    public void BlastOff()
    {
        Debug.Log("YOU TOUCHED ME");
        Rocket.GetComponent<Rigidbody>().freezeRotation = true;
        Rocket.GetComponent<Animator>().SetBool("LiftOffBool", true);
 
        RocketParticleSystem.gameObject.SetActive(true);
        RocketParticleSystem.Play();
        Destroy(Rocket, 2);
    }

    



}
