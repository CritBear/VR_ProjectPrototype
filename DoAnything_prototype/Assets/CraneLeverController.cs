using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class CraneLeverController : MonoBehaviour
{
    public Transform horizontalLever, verticalLever, downLever;

    public UnityEvent onHLeverStartSelected;
    public UnityEvent onHLeverEndSelected;
    public UnityEvent onVLeverStartSelected;
    public UnityEvent onVLeverEndSelected;
    public UnityEvent onDLeverStartSelected;
    public UnityEvent onDLeverEndSelected;
    public UnityEvent onHLeverDown;
    public UnityEvent onHLeverUp;
    public UnityEvent onVLeverDown;
    public UnityEvent onVLeverUp;
    public UnityEvent onDLeverDown;
    public UnityEvent onDLeverUp;

    private WaitForSeconds delay = new WaitForSeconds(0.2f);

    public void StartCheckHLever()
    {
        onHLeverStartSelected.Invoke();
        StartCoroutine(CheckHLever());
        
    }

    public void StopCheckHLever()
    {
        onHLeverEndSelected.Invoke();
        StopAllCoroutines();
        //StopCoroutine(CheckHLever());
    }

    public void StartCheckVLever()
    {
        onVLeverStartSelected.Invoke();
        StartCoroutine(CheckVLever());
    }

    public void StopCheckVLever()
    {
        onVLeverEndSelected.Invoke();
        StopAllCoroutines();
        //StopCoroutine(CheckVLever());
    }

    public void StartCheckDLever()
    {
        onDLeverStartSelected.Invoke();
        StartCoroutine(CheckDLever());
    }

    public void StopCheckDLever()
    {
        onDLeverEndSelected.Invoke();
        StopAllCoroutines();
        //StopCoroutine(CheckDLever());
    }

    IEnumerator CheckHLever()
    {
        while (true)
        {
            if (horizontalLever.rotation.eulerAngles.x < 330 && horizontalLever.rotation.eulerAngles.x < 270) {
                onHLeverUp.Invoke();
            } else if (horizontalLever.rotation.eulerAngles.x > 30) {
                onHLeverDown.Invoke();
            }
            yield return null;
        }
    }

    IEnumerator CheckVLever()
    {
        while (true)
        {
            if (verticalLever.rotation.eulerAngles.x < 330 && verticalLever.rotation.eulerAngles.x < 270) {
                onVLeverUp.Invoke();
            } else if (verticalLever.rotation.eulerAngles.x > 30) {
                onVLeverDown.Invoke();
            }
            yield return null;
        }
    }

    IEnumerator CheckDLever()
    {
        while (true)
        {
            if (downLever.rotation.eulerAngles.x < 330 && downLever.rotation.eulerAngles.x < 270) {
                onDLeverUp.Invoke();
            } else if (downLever.rotation.eulerAngles.x > 30) {
                onDLeverDown.Invoke();
            }
            yield return null;
        }
    }
}
