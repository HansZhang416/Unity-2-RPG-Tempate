using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Response", menuName="CustomObject/Dialogue/Reponse")]

public class DialogueResponse : ScriptableObject
{
   public string Text;
   public DialogueBranch nextBranch;
}
