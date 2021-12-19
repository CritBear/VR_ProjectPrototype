using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Light light;
    public Image img;
    private void FixedUpdate()
    {
        if(light.enabled == true)
        {
            img.enabled = true;
        }
    }
}
