using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphereScript : MonoBehaviour
{


    private Rigidbody sphereRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        this.sphereRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   if (Input.GetKey(KeyCode.W))
        {
    
            this.sphereRigidBody.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime);
            
        }else if (Input.GetKey(KeyCode.S))
        {
            this.sphereRigidBody.MovePosition(transform.position + -transform.forward * Time.fixedDeltaTime);
        }else if (Input.GetKey(KeyCode.D))
        {
            this.sphereRigidBody.MovePosition(transform.position + transform.right * Time.fixedDeltaTime);
        }else if (Input.GetKey(KeyCode.A))
        {
            this.sphereRigidBody.MovePosition(transform.position + -transform.right * Time.fixedDeltaTime);
        }else
        {
            Debug.Log("No-Key pressed");
        }
    }
}