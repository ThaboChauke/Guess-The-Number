using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    //public InputField userInput;
    public TMP_InputField userInput;
    public TMP_Text gameLabel;
    public int randomNum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomNum = 10;
        gameLabel.text = "";
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
            gameLabel.text = "Please Enter a Number";
        }

    }
}
