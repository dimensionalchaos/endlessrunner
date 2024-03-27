using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    
    GameObject shatter;
    float timer;
    void Awake()
    {
        timer = 2.0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Collide()
    {
        timer-=Time.deltaTime;
        if(timer<=0)
        {
            Destroy(gameObject.GetComponent<MeshCollider>());
            Destroy(gameObject.GetComponent<Rigidbody>());
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            shatter = transform.GetChild(0).gameObject;
            shatter.SetActive(true);
            
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("ball"))
        {
            Collide();
        }
    }
}
