using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class GameManager : MonoBehaviour
{

    [Header("Interactor Object - cabinet")]
    public GameObject cabinetRdoor;
    public GameObject cabinetLdoor;
    public GameObject cabinetKey;

    [Space(3)]
    [Header("Interactor Object - safe")]
    public GameObject safe;
    

    bool istied = true;

    private void Awake()
    {
        //cabinetRdoor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //cabinetLdoor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

    }
    void Start()
    {
        
    }

    public void socketCheck()
    {

    }

    public void matchCabinetKey()
    {
        //cabinetRdoor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        //cabinetLdoor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
