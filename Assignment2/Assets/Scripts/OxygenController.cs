using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenController : MonoBehaviour
{
    public GameObject oxygen;
    public GameObject player;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //InstantiatePrefab(Object assetComponentOrGameObject);


    //check for when player and oxygen bubbles collide so that I can give the player air...
    private IEnumerator OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player" && player.GetComponent<PlayerController>().amountOfNitro < 1){
            player.GetComponent<PlayerController>().amountOfNitro++; 

            oxygen.transform.position = new Vector3(-100f, 0f, 0f); // place bubbles off map
            yield return new WaitForSeconds(5); // wait 15 seconds  then spawn bubbles again
            oxygen.transform.position = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-.3f, -4.5f), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 

}
