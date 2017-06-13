#region System Usage 
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


#endregion

public class CutRope : MonoBehaviour {

	
	void Start () 
	{
		
		
	}
	
	
	void Update () 
	{
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D _hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if (_hit.collider) 
            {
                if (_hit.collider.tag =="link")
                {
                    Destroy(_hit.collider.gameObject);
                    Destroy(_hit.collider.gameObject.transform.parent.gameObject,2f);
                }
            }

        }
		
		
	}
}
