using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public SnailController[] snails;

    private Color[] colors = { Color.blue, Color.red, Color.green, Color.yellow, Color.cyan, Color.white };
    private int dieValue;
    private bool canSnailMove;
    private AudioSource diceRollAudio;


    public Text uiTitleText;
    public Image uiDiceRollImage;
    public CanvasGroup menuCanvasGroup;


   

    // Start is called before the first frame update
    void Start()
    {
        diceRollAudio = GetComponent<AudioSource>();
        canSnailMove = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canSnailMove)
        {
            dieValue = Roll();
            if (dieValue > 3)
            {
                Debug.LogWarning("DIE ROLL WAS WHITE");
                uiDiceRollImage.color = colors[dieValue];
            }
            else
            {
                uiDiceRollImage.color = colors[dieValue];
                snails[dieValue].MoveSnail();
            }
        }

    }

    //Method that Rolls the Dice
    public int Roll()
    {
        diceRollAudio.Play();
        return Random.Range(0, 5);
    }

    private void OnTriggerEnter(Collider other)
    {

        menuCanvasGroup.alpha = 1;

        for (int i = 0; i < snails.Length; i++)
        { 

            if (other.CompareTag(snails[i].tag))
            {
                canSnailMove = false;
                print("We Have a Winner!!! It's the... " + other.tag.ToString() + " !!!");
                uiTitleText.text = other.tag.ToString() + " Wins!";
            }
        }

        menuCanvasGroup.alpha = 1;

    }

    public void QuitButtonClicked()
    {
        Application.Quit();
    }

    public void ReplayButtonClicked()
    {
        SceneManager.LoadScene("Main");
    }
}
