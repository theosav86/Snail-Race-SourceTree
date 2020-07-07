using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieRoll : MonoBehaviour
{

    /* This class handles the die rolls*/

    private GameObject snail;
    private int dieValue;
    private bool hasMoved;
    
    enum playerEnum {BLUE, RED, YELLOW, GREEN, CYAN, WHITE};
    
    // Start is called before the first frame update
    void Start()
    {
        hasMoved = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            dieValue = Roll();
            hasMoved = false;
            MovePlayer(dieValue);
        }
    }
    
    //Method that Rolls the die

    public int Roll()
    {
        return Random.Range(0, 6);      
    }

    //method that moves the X (Color) player depending on the DieRoll()
    public void MovePlayer(int X)
    {
       
       //Move the X player;
        MoveIt(X, hasMoved);
    }

    public void MoveIt(int X, bool hasMoved)
    {
        //Check what was the DieRoll (number) and compare to each Color.
        switch (X)
        {

            case 0:
        //        print("BLUE !!!");
                snail = GameObject.FindGameObjectWithTag("Blue Player");
                break;
            case 1:
         //       print("RED !!!");
                snail = GameObject.FindGameObjectWithTag("Red Player");
                break;
            case 2:
          //      print("YELLOW !!!");
                snail = GameObject.FindGameObjectWithTag("Yellow Player");
                break;
            case 3:
          //      print("GREEN !!!");
                snail = GameObject.FindGameObjectWithTag("Green Player");
                break;
            case 4:
         //       print("CYAN !!!");
                snail = GameObject.FindGameObjectWithTag("Cyan Player");
                break;
            default:
                print("WHITE !!! Time for Random Event!");
                break;
        }

        //Then move the specific Snail 
        snail.GetComponent<SnailMovement>().Animating(hasMoved);
        hasMoved = true; // In order to return to idle animation state.

    }

    

}
