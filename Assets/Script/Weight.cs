#region System Usage 
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


#endregion

public class Weight : MonoBehaviour {

    public float chainEndDis = -0.3f;
	void Start () 
	{
		
		
	}
	
	
	void Update () 
	{
		
		
	}

    public void ConnectRopeEnd(Rigidbody2D endRb)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.connectedBody = endRb;

        joint.autoConfigureConnectedAnchor = false; 
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0,chainEndDis);


    }
}
