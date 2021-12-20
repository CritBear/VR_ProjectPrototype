using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationLever : MonoBehaviour
{
    private VibrationManager manager;
    [Range(0, 1)]
    public float MinAmplitude = 0f;
    [Range(0, 1)]
    public float MaxAmplitude = 1f;

    public float Radius = 0.03f;
    public float Length = 1f;

    private WaitForSeconds delay = new WaitForSeconds(0.2f);

    public bool isVertical = false;

    void Start()
    {
        manager = GameObject.Find("VibrationManager").GetComponent<VibrationManager>();
    }

    public void StartCheckTrajectory()
    {
        StartCoroutine(StartPeriodicHaptics());
    }

    public void StopCheckTrajectory()
    {
        StopAllCoroutines();
    }

    IEnumerator StartPeriodicHaptics()
    {
        while (true)
        {
            bool isSend = false;
            if (isVertical) {
                if(Mathf.Abs(manager.RightController.transform.position.z - transform.position.z) > Radius) {
                    SendHaptics(MaxAmplitude);
                    isSend = true;
                }
            } else {
                if(Mathf.Abs(manager.RightController.transform.position.x - transform.position.x) > Radius) {
                    SendHaptics(MaxAmplitude);
                    isSend = true;
                }
            }

            if (!isSend) {
                float distance = Mathf.Abs(Vector3.Distance(transform.position, manager.RightController.transform.position) - Length);
                if (distance > Radius) {
                    SendHaptics(Mathf.Clamp(MinAmplitude + (distance - Radius), MinAmplitude, MaxAmplitude));
                }
            }
            yield return delay;
        }
    }

    void SendHaptics(float amplitude)
    {
        if (manager.RightController != null)
            manager.RightController.SendHapticImpulse(amplitude, 0.2f);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + transform.up * Length);
        Gizmos.DrawSphere(transform.position, Radius);
        Gizmos.DrawSphere(transform.position + transform.up * Length, Radius);
    }
}
