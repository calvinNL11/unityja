using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void onTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player"))
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

