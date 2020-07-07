using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWinCondition : MonoBehaviour
{

    private BoxCollider boxCollider;
    private bool touchingFinish = false;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //check for player's collision with game object tagged Dock
            if (touchingFinish)
                print("We have a WINNER ! ! ! ");
        }
    }

  /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Blue Player"))
        
    }*/

    //Method to say who won
    private void OnTriggerEnter (Collider other)
    {
        touchingFinish = true;

       if (other.gameObject.CompareTag("Blue Player"))
        {
            Destroy(other);
            print("BLUE WINS!!!");
        }
        if (other.gameObject.CompareTag("Red Player"))
        {
            print("RED WINS!!!");
        }
        if (other.gameObject.CompareTag("Yellow Player")) //== "Yellow Player")
        {
            print("YELLOW WINS!!!");
        }
        if (other.gameObject.CompareTag("Green Player"))
        {
            print("GREEN WINS!!!");
        }
        if (other.gameObject.CompareTag("Cyan Player"))
        {
            print("CYAN WINS!!!");
        }
    }
}
