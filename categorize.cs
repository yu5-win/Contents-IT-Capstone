using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class categorize : MonoBehaviour
{
    public GameObject[] answers = new GameObject[3];
    bool answer_0 = false;
    bool answer_1 = false;
    bool answer_2 = false;
    public bool is_full = false;

    void Start()
    {
        
    }
    void Update()
    {
        if(answer_0 && answer_1 && answer_2)
        {
            is_full = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == answers[0])
        {
            answer_0 = true;
        }
        else if(other.gameObject == answers[1])
        {
            answer_1 = true;
        }
        else if (other.gameObject == answers[2])
        {
            answer_2 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == answers[0])
        {
            answer_0 = false;
        }
        else if (other.gameObject == answers[1])
        {
            answer_1 = false;
        }
        else if (other.gameObject == answers[2])
        {
            answer_2 = false;
        }
    }
}
