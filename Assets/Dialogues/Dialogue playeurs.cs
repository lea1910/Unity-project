using UnityEngine;
using TMPro;

public class Dialogueplayeurs : MonoBehaviour
{

    public dialogueasset dialogueAsset;
    public TMP_Text dialogueText;
    public GameObject dialogueBox;

    private int dialogueLineIndex;

    private void Start()
    {
        dialogueText.text = dialogueAsset.dialogue[0];
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //dialogueLineIndex += 1;
            dialogueLineIndex++;

            if (dialogueLineIndex < dialogueAsset.dialogue.Length)
            {
                dialogueText.text = dialogueAsset.dialogue[dialogueLineIndex];
            }
            else
            {
                dialogueBox.gameObject.SetActive(false);
            }
        }
    }

}