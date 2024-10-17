using TMPro;
using UnityEngine;

public class prog17oct : MonoBehaviour
{
   
    public TMP_Text messageText; // nouvelle variable public ( faite pour contenir du texte )    
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        ResetGame();
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text))
        {
            messageText.text = "Entre un nombre valide zeubi!";
            numberInput.text = "";
            return;
        }

        if(int.TryParse(numberInput.text, out int playerNumber))
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "victoir bg ";
            }
            else if (playerNumber > randomNumber)
            {
                messageText.text = "Ah le nul";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "Plus abruti!";
            }
            
        }
        else 
        {
            messageText.text = "Entre un nombre valide zeubi!";
        }

      
    }

    public void  ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated numbert: " + randomNumber);
        messageText.text = "Guess the number...";
    }
}
