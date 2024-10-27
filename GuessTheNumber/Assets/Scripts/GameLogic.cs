using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    //public InputField userInput;
    public TMP_InputField userInput;
    public int randomNum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomNum = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        //Debug.Log("Clicked");
        Debug.Log(randomNum);
        Debug.Log(userInput.text);
    }
}
