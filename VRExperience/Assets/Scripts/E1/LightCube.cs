using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCube : MonoBehaviour {

    public Light light1;
    public Light light2;
    public Light light3;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            light1.intensity = 0.8f;
            light2.intensity = 0.8f;
            light3.intensity = 0.8f;
            Debug.Log("OnTriggerEnter");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            light1.intensity = 1f;
            light2.intensity = 1f;
            light3.intensity = 1f;
            Debug.Log("OnTriggerExit");
        }
    }

}
