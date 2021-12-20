using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerDoorController : MonoBehaviour
{
    public Transform LeftDoor, RightDoor;
    private bool OpenDoor = false;
    private float OpenSpeed = 0.2f;

    public void DoorActivated()
    {
        OpenDoor = true;
    }

    void Update()
    {
        if(OpenDoor) {
            Quaternion targetRotation = Quaternion.Euler(0, -150, 0); 
            LeftDoor.localRotation = Quaternion.Slerp(LeftDoor.localRotation, targetRotation, OpenSpeed * Time.deltaTime);

            targetRotation = Quaternion.Euler(0, 150, 0); 
            RightDoor.localRotation = Quaternion.Slerp(RightDoor.localRotation, targetRotation, OpenSpeed * Time.deltaTime);
        }
    }
}