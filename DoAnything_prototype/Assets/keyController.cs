using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "lock")
        {
            this.GetComponent<Rigidbody>().useGravity = false;
            //this.transform.position = collision.gameObject.transform.position;
        }
    }

}
