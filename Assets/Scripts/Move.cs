using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speedMove = 10.0F;
    private float keyMove;
    private Rigidbody2D rigidBody;
    private float widthScene;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        widthScene = Camera.main.aspect * Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        keyMove = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(keyMove*speedMove,rigidBody.velocity.y);
        if(transform.position.x< -widthScene)
        {
            transform.position = new Vector2(widthScene,transform.position.y);
        }
        if (transform.position.x > widthScene)
        {
            transform.position = new Vector2(-widthScene, transform.position.y);
        }
    }
}
