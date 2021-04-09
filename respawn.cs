using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject animal_1_Prefab;
    private Transform animal_1_Pos;
    public GameObject animal_2_Prefab;
    private Transform animal_2_Pos;

    // Start is called before the first frame update
    void Start()
    {
        animal_1_Pos = animal_1_Prefab.transform;
        animal_2_Pos = animal_2_Prefab.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        GameObject CollObject = other.gameObject;

        if(other.gameObject.tag == "cube")
        {
            Destroy(other.gameObject);
            Instantiate(CollObject, animal_1_Pos.position, animal_1_Pos.rotation);
            CollObject = null;
        }
        else if(other.gameObject.tag == "sphere")
        {
            Destroy(other.gameObject);
            Instantiate(CollObject, animal_2_Pos.position, animal_2_Pos.rotation);
            CollObject = null;

        }
    }
}
