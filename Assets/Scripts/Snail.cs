using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snail : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method that moves the snails
    public virtual void MoveSnail()
    {

        transform.Translate(new Vector3(0f, 0f, 3f));
    }
}
