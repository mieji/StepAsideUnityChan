using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {
    private GameObject unitychan;
    private float defference;
	// Use this for initialization
	void Start () {
        unitychan = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
        //       this.defference = Mathf.Abs(this.transform.position.z)- Mathf.Abs(unitychan.transform.position.z);
        this.defference = (this.transform.position.z + 300) - (unitychan.transform.position.z + 300);
        if (defference < -3)
        {
            Destroy(this.gameObject);
        }
	}
}
