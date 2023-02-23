using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //Object yang akan mengikuti kamera
    [SerializeField] GameObject thingToFollow;
    
    //LateUpdate = supaya kamera tidak patah2, karena mengikuti frame dari object
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + (new Vector3(0,0,-10)) ;
    }
}
