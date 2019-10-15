using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Reference to Rigidbody 2D
    public Rigidbody2D playerRigidBody; 
    // reference to player
    public GameObject player;
    public SpriteRenderer sprite;
    // ref to animator
    public Animator myAnim;
    // speed
    public float moveSpeed = 5f;
    private int score = 0;
    private int currentGold = 0; 

    public int oxygenCylinder; 

    public int amountOfNitro = 0; 

    // Start is called before the first frame update
    void Start()
    {
        oxygenCylinder = 2;
        amountOfNitro = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // get player's sprite renderer
        sprite = player.GetComponent<SpriteRenderer>();

        // moving the player
        playerRigidBody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        ) * moveSpeed;

        // flipping the animation if the character moves in a different direction.
        if(playerRigidBody.velocity.x < - 0.1){
            sprite.flipX = true;  
        } else if(playerRigidBody.velocity.x > 0.1){
            sprite.flipX = false;  
        }

        // setting the moveX and moveY of the players Animator so that it executes the proper animations.. 
        myAnim.SetFloat("moveX", playerRigidBody.velocity.x);
        myAnim.SetFloat("moveY", playerRigidBody.velocity.y);

        // Wrapping swimmer on screen
        if(player.transform.position.x < -8.64f){
            var pos = player.transform.position;
            player.transform.position = new Vector3(8.5f, pos.y, pos.z);
        } else if(player.transform.position.x > 8.5f){
            var pos = player.transform.position;
            player.transform.position = new Vector3(-8.4f, pos.y, pos.z);
        }     

        // check if dead
        if(this.oxygenCylinder == 0){
            Debug.Log("Oh Dear, you are dead!");
            SceneManager.LoadScene(0);
        }

        // speed burst from nitro cylinder;
        StartCoroutine(checkForSpeedBurst());
            
    }


    IEnumerator checkForSpeedBurst(){
        if (Input.GetKeyDown("space"))
        {
            if(this.amountOfNitro == 1){
                this.moveSpeed = 10f;
                this.amountOfNitro = 0;
                yield return new WaitForSeconds(5);
                this.moveSpeed = 5f;
            }
         }
    }

    public void setScore(int newScore){
        this.score += newScore;
    }

    public int getScore(){
        return this.score;
    }

    public int getCurrentGold(){
        return this.currentGold;
    }

    public void setCurrentGold(int gold){
        this.currentGold = gold; 
    }
}
