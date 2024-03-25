using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballrotate : MonoBehaviour
{
    Rigidbody rb; 
    RaycastHit hit;
    float yvel;
    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!onground())
        {
            yvel =9.8f;
        }
        else{
            yvel  = 0f;
        }
        Debug.DrawRay(transform.position,Vector3.down*0.4f,Color.green);
        rb.AddForce(Vector3.down*yvel,ForceMode.Acceleration);
        transform.Rotate(new Vector3(-10,0,0));
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up*0.5f,ForceMode.Impulse);
        }
    }
    bool onground()
    {
        if(Physics.Raycast(transform.position,Vector3.down,out hit,0.4f))
        {
            if(hit.collider.gameObject.tag=="floor")
            {
                return true;
            }
            else{
                return false;
            }
        }
        else{
            return false;
        }
    }
}
