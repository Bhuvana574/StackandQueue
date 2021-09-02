using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StackExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI stackDebug;
    // Start is called before the first frame update
    void Start()
    {
        //define our stack
        Stack stack = new Stack();
        // prepare our data
        int firstPlayerScore = 50;
        int secondPlayerScore = 70;
        int thirdPlayerScore = 100;
        //push  a new player score into stack
        stack.Push(firstPlayerScore);
        stack.Push(secondPlayerScore);
        stack.Push(thirdPlayerScore);
        //show info in stack
        ShowInformationInStack(stack);
        //pop player score from stack
        stack.Pop();
        ShowInformationInStack(stack);
        stack.Pop();
        ShowInformationInStack(stack);
        stack.Pop();
       

    }

    void ShowInformationInStack(Stack stack)
    {
        stackDebug.text += ".....\n";
        foreach (var stackitem in stack)
        {

            Debug.Log(stack.Count);
            //stackDebug.text = "\n";
            stackDebug.text += $"{stackitem}\n";
           
        }
    }




}