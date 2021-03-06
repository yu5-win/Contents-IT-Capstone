using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class measureWeight : MonoBehaviour
{
    private GameObject weight;
    public bool is_OnPosition = false;

    public float GetObjectMass()
    {
        return weight.GetComponent<Rigidbody>().mass;
    }
    public void OnTriggerEnter(Collider other)
    {
        weight = other.gameObject;
        is_OnPosition = true;
    }

    private void OnTriggerExit(Collider other)
    {
        weight = null;
        is_OnPosition = false;
    }
}
