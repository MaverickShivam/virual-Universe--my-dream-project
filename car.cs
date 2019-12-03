using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;

public class car : MonoBehaviour {
    public GameObject player;
    public Rigidbody rb;
    float angle;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
}
	
	// Update is called once per frame
	void Update () {
        angle = this.transform.rotation.eulerAngles.y;

        float dist = Vector3.Distance(this.transform.position, player.transform.position);
        if (dist <= 3)
        {
            player.transform.SetParent(this.transform);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 temp = this.transform.position;
            temp.x -= 0.5f * Mathf.Cos((angle * Mathf.PI) / 180);
            temp.z += 0.5f * Mathf.Sin((angle * Mathf.PI) / 180);
            this.transform.position = temp;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 temp = this.transform.position;
            temp.x += 0.5f * Mathf.Cos((angle * Mathf.PI) / 180);
            temp.z -= 0.5f * Mathf.Sin((angle * Mathf.PI) / 180);
            this.transform.position = temp;
        }


        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 1.5f, 0);
        }
            
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -1.5f, 0);
        }
            
    }
}
