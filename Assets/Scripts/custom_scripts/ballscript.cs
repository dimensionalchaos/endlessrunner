using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballrotate : MonoBehaviour
{
    [SerializeField]
    GameObject ballPrefab;
    float throwForce = 20f;
    Rigidbody rb; 
    RaycastHit hit;
    float yvel;
    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update(){
            if (Input.GetMouseButtonDown(0))
            {
            // Get the mouse position in screen coordinates
            Vector3 mousePosition = Input.mousePosition;

            // Convert screen coordinates to world coordinates
            Vector3 worldMousePosition = gameObject.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 100f));

            // Calculate the direction from the ball's initial position to the mouse position
            Vector3 direction = (worldMousePosition - transform.position).normalized;

            // Instantiate the ball GameObject at the camera position
            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);

            // Apply force to the ball in the direction calculated
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(direction * throwForce, ForceMode.Impulse);
            }
        }
    }
}

   

