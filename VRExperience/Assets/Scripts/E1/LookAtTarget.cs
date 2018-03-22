using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour {

    public Transform target;
    private Transform m_Transform;

    // Use this for initialization
    void Start () {
        m_Transform = this.transform;

    }
	
	// Update is called once per frame
	void Update () {
        m_Transform.LookAt(target);
        m_Transform.eulerAngles = new Vector3(0, m_Transform.eulerAngles.y, 0 );
    }
}
