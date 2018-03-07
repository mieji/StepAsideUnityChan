using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private int startPos = -160;
    private int goalPos = 120;
    private float posRange = 3.4f;
    private GameObject uniChan;
    private float upos; // unitychan のz位置
    private float fpos; // unitychan より45m前のz位置


    // Use this for initialization
    void Start () {
            this.uniChan = GameObject.Find("unitychan");
    }
	
	// Update is called once per frame
	void Update () {

        this.upos = uniChan.transform.position.z;
        this.fpos = upos+45;

        if ((startPos-fpos) < 0 && startPos < goalPos)
        {
            itemGenarate();
        }

        Debug.Log(startPos - fpos);
	}
    private void itemGenarate()
    {

        this.startPos += 15;

            int num = Random.Range(0, 10);
            if (num <= 1)
            {
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, upos + 45);
                }
            }
            else
            {
                for (int j = -1; j < 2; j++)
                {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-5, 6);
                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, upos + 45 + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, upos + 45 + offsetZ);
                    }
                }
            }

    }
}
