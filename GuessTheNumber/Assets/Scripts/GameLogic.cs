using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    //public InputField userInput;
    public TMP_InputField userInput;
    public TMP_Text gameLabel;
    public Button gameButton;
    private int randomNum;
    public int randomNumMin;
    public int randomNumMax;
    private bool isGameWon;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResetGame();
    }


    private void ResetGame()
    {
        if (isGameWon)
        {

            gameLabel.text = "You Won! Guess a number between " + randomNumMin + " and " + (randomNumMax - 1);
            isGameWon = false;
        }
        else
        {
            gameLabel.text = "Guess a number between " + randomNumMin + " and " + (randomNumMax - 1);
        }
        gameLabel.text = "";
        randomNum = GenerateRandomNumber(randomNumMin, randomNumMax);
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
                isGameWon = true;
                ResetGame();
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
