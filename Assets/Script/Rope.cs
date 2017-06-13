#region System Usage 
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


#endregion

public class Rope : MonoBehaviour {

    public GameObject hook; 
    public GameObject linkPref;
    //public GameObject Mass; 
    public int links = 7;
    public Weight weight;

    private void Awake()
    {
        weight = FindObjectOfType<Weight>();
    }
    void Start () 
	{
        GenRope();


    }
	
	
	void Update () 
	{
		
		
	}

    void GenRope()
    {
        Rigidbody2D prevRb = hook.GetComponent<Rigidbody2D>();
        for (int i = 0 ; i < links ; i++)
        {
           GameObject link =  Instantiate(linkPref,transform);

            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();

            joint.connectedBody = prevRb;

            if (i < links - 1 )
            {
                prevRb = link.GetComponent<Rigidbody2D>();
            }
            else
            {
                weight.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }
           




        }

        
       



        



    }
}
