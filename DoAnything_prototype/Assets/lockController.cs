using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockController : MonoBehaviour
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
        //Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag == "key")
        {
            //Debug.Log("Collision!!");
            //collision.transform.Rotate(new Vector3(90, 0, 0));
            //collision.transform.position = new Vector3(this.transform.position.x,
            //    this.transform.position.y + this.transform.localScale.y,
            //    this.transform.position.z);
        }
    }
}
