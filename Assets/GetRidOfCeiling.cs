using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRidOfCeiling : MonoBehaviour
{
    public GameObject ceiling;
    private int key = 1;
    

   public void GetRid()
    {
        if(key == 1)
        {
            key = 2;
        }
        else if (key == 2)
        {
            ceiling.SetActive(false);
            key = 0;
        }
        else if (key == 0)
        {
            ceiling.SetActive(true);
            key = 1;
        }

    }


}
