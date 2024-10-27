using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    //public InputField userInput;
    public TMP_InputField userInput;
    public TMP_Text gameLabel;
    private int randomNum;
    public int randomNumMin;
    public int randomNumMax;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomNum = GenerateRandomNumber(randomNumMin, randomNumMax);
        gameLabel.text = "Guess a number between " + randomNumMin + " and " + randomNumMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        string userInputValue = userInput.text;
        if (userInputValue != "")
        {
            int answer = int.Parse(userInputValue);

            if (answer == randomNum)
            {
                gameLabel.text = "Correct!";
            }
            else if (answer > randomNum)
            {
                gameLabel.text = "Try Lower!.";
            }
            else
            {
                gameLabel.text = "Try Higher!";
            }
        }

        else
        {
            gameLabel.text = "Please Enter a Number!";
        }
    }

    private int GenerateRandomNumber(int min,  int max)
    {
        return Random.Range(min, max);
    }
}
