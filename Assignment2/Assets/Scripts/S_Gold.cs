using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class S_Gold : MonoBehaviour
{
    public GameObject player;
    //public GameObject gold; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private IEnumerator OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Debug.Log("Here is some Small Gold!");

            if(player.GetComponent<PlayerController>().getCurrentGold() == 0){
                player.GetComponent<PlayerController>().setCurrentGold(1);
                // change player speed
                player.GetComponent<PlayerController>().moveSpeed = 4f;
                // after grabbing the gold, a couple things need to happen.
                // 1. set a time out for the gold like oxygen
                // 2. make the gold dissapear and reappear just like the oxygen using timeout.
                this.transform.position = new Vector3(-120f, 0f, 0f);
                yield return new WaitForSeconds(5); // wait 5 seconds  then spawn gold again
                this.transform.position = new Vector3(Random.Range(-7.0f, 7.0f), -4.63f, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
