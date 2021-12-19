using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationRenderer : MonoBehaviour
{
    public float Length = 1f;
    public float Radius = 0.03f;

    private CapsuleCollider coll;

    [Range(0, 1)]
    public float MinAmplitude = 0f;
    [Range(0, 1)]
    public float MaxAmplitude = 1f;

    private Vector3 closestPoint;
    private VibrationManager manager;
    private WaitForSeconds delay = new WaitForSeconds(0.2f);

    void Start()
    {
        coll = gameObject.AddComponent<CapsuleCollider>();
        coll.center = new Vector3(0, 0, Length / 2);
        coll.radius = Radius;
        coll.height = Length;
        coll.direction = 2;
        coll.isTrigger = true;

        manager = GameObject.Find("VibrationManager").GetComponent<VibrationManager>();
    }

    void Update()
    {
        closestPoint = coll.ClosestPoint(manager.RightController.transform.position);
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
            closestPoint = coll.ClosestPoint(manager.RightController.transform.position);
            float distance = Vector3.Distance(closestPoint, manager.RightController.transform.position);
            if(distance > Radius) {
                SendHaptics(Mathf.Clamp(MinAmplitude + (distance - Radius) * 10, MinAmplitude, MaxAmplitude));
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
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * Length);
        Gizmos.DrawSphere(transform.position, Radius);
        Gizmos.DrawSphere(transform.position + transform.forward * Length, Radius);
    }
}
