using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shattering : MonoBehaviour
{
    [SerializeField]
    GameObject centre;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*int i = 0;
        while(transform.GetChild(i)!=null)
        {
            Vector3 dir = transform.GetChild(i).transform.position-centre.transform.position;
            dir.Normalize();
            Rigidbody rb = transform.GetChild(i).gameObject.GetComponent<Rigidbody>();
            rb.AddForceAtPosition(dir*2,transform.GetChild(i).transform.position,ForceMode.Impulse);   
            i++;
        }*/
    }
}
