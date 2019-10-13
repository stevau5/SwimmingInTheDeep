using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Reference to Rigidbody 2D
    public Rigidbody2D playerRigidBody; 

    // ref to animator
    public Animator myAnim;
    // speed
    public float moveSpeed = 3.5f;

     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerRigidBody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        ) * moveSpeed;
    }
}
