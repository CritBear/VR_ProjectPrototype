using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VibrationManager : MonoBehaviour
{
    public ActionBasedController LeftController, RightController;

    void Start()
    {
        StartCoroutine(StartPeriodicHaptics());
    }

    IEnumerator StartPeriodicHaptics()
    {
        // Trigger haptics every second
        var delay = new WaitForSeconds(1f);
 
        while (true)
        {
            yield return delay;
            SendHaptics();
        }
    }

    void SendHaptics()
    {
        if (LeftController != null)
            LeftController.SendHapticImpulse(0.7f, 0.1f);
    }
}
