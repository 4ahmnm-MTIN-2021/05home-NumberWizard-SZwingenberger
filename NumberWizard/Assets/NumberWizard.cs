using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;
    public Text guessNext;

    private void Start()
    {
     
        max = 100;
        min = 1;
        guess = 50;

        Debug.Log("Hello I am the NUmber Wizard");
        Debug.Log("Pick a number between 1-100");
        Debug.Log("Tell me if your number is higher or lower than: + guess");
        Debug.Log("Push Arrow Up if your number is higher, Arrow Down if it is lower,and Enter if it is correct");

        max = max + 1;
    }

   

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
         if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
         if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Megamind");
        
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it lower or higher than..." + guess);
        guessNext.text = guess.ToString();
    }

}
