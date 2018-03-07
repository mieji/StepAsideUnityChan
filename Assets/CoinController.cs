using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {
    private GameObject unitychan;
    private float defference;

    // Use this for initialization
    void Start () {
        this.transform.Rotate(0, Random.Range(0, 360),0);
        this.unitychan = GameObject.Find("unitychan");
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0, 3, 0);
        //     this.defference = Mathf.Abs(this.transform.position.z) - Mathf.Abs(unitychan.transform.position.z);
        this.defference = (this.transform.position.z + 300) - (unitychan.transform.position.z + 300);
        if (defference < -3)
        {
            Destroy(this.gameObject);
        }
	}
}
