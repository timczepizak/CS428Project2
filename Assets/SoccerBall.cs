using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{

    public GameObject Ball;
    public ParticleSystem Pop;

    public void popBall()
    {
        Destroy(Ball);
        Pop.Play();

    }
}
