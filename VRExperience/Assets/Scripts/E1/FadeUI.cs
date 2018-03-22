using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class FadeUI : MonoBehaviour {

    public GameObject fadeUI;
    void Start()
    {
        GetComponent<VRTK_HeadsetCollision>().HeadsetCollisionDetect += CollisionDetect_HeadsetCollisionDetect;
        GetComponent<VRTK_HeadsetCollision>().HeadsetCollisionEnded += CollisionDetect_HeadsetCollisionEnded;
    
    }

    private void CollisionDetect_HeadsetCollisionDetect(object sender, HeadsetCollisionEventArgs e)
    {
        fadeUI.SetActive(true);
    }

    private void CollisionDetect_HeadsetCollisionEnded(object sender, HeadsetCollisionEventArgs e)
    {
        fadeUI.SetActive(false);
    }

}
