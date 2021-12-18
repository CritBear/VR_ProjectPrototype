using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class KeyController : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.GetComponent<XRSocketInteractor>().enabled = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "CabinetKey")
        {
            this.gameObject.GetComponent<XRSocketInteractor>().enabled = true;
        }
    }
}
