using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumweight : MonoBehaviour
{
    public measureWeight[] ob;
    public float[] mass = new float[5];
    public GameObject text;

    public void check()
    {
        if(ob[0].is_OnPosition && ob[1].is_OnPosition && ob[2].is_OnPosition && ob[3].is_OnPosition && ob[4].is_OnPosition)
        {
            for(int i = 0; i < 5; i++)
            {
                mass[i] = ob[i].GetObjectMass();
            }
            if(mass[0] > mass[1] && mass[1] > mass[2] && mass[2] > mass[3] && mass[3] > mass[4])
            {
                Debug.Log("success");
                text.SetActive(true);
            }
            else
            {
                Debug.Log("fail");
            }
        }
        else
        {
            Debug.Log("fail");
        }
    }
}
