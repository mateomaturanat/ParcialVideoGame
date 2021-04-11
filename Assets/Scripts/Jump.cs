using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Platform");
        if ((collision.gameObject.GetComponent<Rigidbody2D>().velocity.y) <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpVelocity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
