using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficConeController : MonoBehaviour {
    private GameObject unitychan;
    private float defference;
	// Use this for initialization
	void Start () {
        this.unitychan = GameObject.Find("unitychan");
		
	}
	
	// Update is called once per frame
	void Update () {
        this.defference = (this.transform.position.z+300) - (unitychan.transform.position.z+300);
        if (defference < -1)
        {
            Destroy(this.gameObject);
        }
	}
}
