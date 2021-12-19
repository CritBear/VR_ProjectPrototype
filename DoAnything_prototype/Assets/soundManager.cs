using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public CharacterController myAvatar;
    Vector3 previous;
    public AudioSource walk;
    public AudioSource breath;
    
    // Start is called before the first frame update
    void Start()
    {
        previous = myAvatar.center;
    }

    // Update is called once per frame
    void Update()
    {
        if(previous != myAvatar.center)
        {
            
        }
        else
        {
            walk.loop = true;
            walk.Play();

            breath.loop = true;
            breath.Play();
        }
        previous = myAvatar.center;
    }
}
