using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailMovement : MonoBehaviour
{

    #region Singleton
    public static SnailMovement instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public bool hasMoved;

    private Animator anim;

   // Start is called before the first frame update
public void Start()
    {
        hasMoved = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    //Method to move the Snail. Animate it.
    public void Animating(bool hasMoved)
    {
        anim.SetTrigger("MoveFlag");
        anim.SetBool("HasMoved", hasMoved);
    }

 
}
