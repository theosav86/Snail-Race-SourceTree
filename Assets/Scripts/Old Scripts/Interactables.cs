using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    public bool interactable;

    // Start is called before the first frame update
    void Start()
    {
        interactable = false;
    }

    public virtual void Interact()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable)
        {
            Interact();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Blue Player"))
        {
            print("BLUE !!!");
            interactable = true;
        }
        else if (other.gameObject.CompareTag("Red Player"))
        {
            print("RED !!!");
            interactable = true;
        }
        else if (other.gameObject.CompareTag("Yellow Player"))
        {
            print("Yellow !!!");
            interactable = true;
        }
        else if (other.gameObject.CompareTag("Green Player"))
        {
            print("GREEN !!!");
            interactable = true;
        }
        else
        {
            print("CYAN !!!");
            interactable = true;
        }
    }
}
