using UnityEngine;

[CreateAssetMenu]
public class dialogueasset : ScriptableObject 
{
    [TextArea(3, 6)]
    public string[]  dialogue;

}
