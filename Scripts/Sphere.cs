using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sphere : MonoBehaviour
{
    Rigidbody rb;

    public float gravity = 100f;
    public float forwarsSpeed = 10f;

    public float moveZ;
    public float moveSpeed = 10f;

   private RoadSpawner roadSpawner;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        roadSpawner = GameObject.Find("RoadSpawner").GetComponent<RoadSpawner>();

    }


    void Update()
    {

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveZ -= moveSpeed * Time.deltaTime;
        }  
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveZ += moveSpeed * Time.deltaTime;
        }
        else
        {
            moveZ = 0f;
        }

        if (transform.position.y < -3f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(forwarsSpeed, 0, moveZ);
        rb.AddForce(new Vector3(0f, -gravity, 0f) * rb.mass);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Create")
        {
            roadSpawner.MakeRoad();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
