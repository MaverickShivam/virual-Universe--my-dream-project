using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class pickup : MonoBehaviour {
    public Transform theDest;
    public GameObject player;
    public GameObject table;
    public float dist1,dist2;
 

	// Use this for initialization
	void Start () {

        
		
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 pos1 = this.transform.position;
        Vector3 pos2 = player.transform.position;
        dist1=Vector3.Distance(pos1, pos2);
        Vector3 pos3 = table.transform.position;
        dist2 = Vector3.Distance(pos1, pos3);
        if (dist1<=3 && dist2>=3.3)
        {

            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("Destination").transform;

        }
        else
        {
            
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().AddForce(Vector3.down * 10.0f);
        }
    }
}
