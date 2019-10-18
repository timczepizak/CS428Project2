using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioChangeSCript : MonoBehaviour
{
    private int key = 1;
    public AudioSource audio;

    public void ChangeAudio()
    {
        if (key == 1)
        {
            audio.pitch = 3f;
            key = 2;
        }
        else if (key == 2)
        {
            audio.pitch = 1f;
            key = 0;
        }
        else if (key == 0)
        {
            audio.pitch = 1f;
            key = 1;
        }

    }
}
