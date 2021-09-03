using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StackExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI stackDebug;
    public GameObject cube;
    public GameObject capsule;
    int i=0;
    int j = 1;
    // Start is called before the first frame update
    void Start()
    {
        //define our stack
        Stack stack = new Stack();
        // prepare our data
       // int firstPlayerScore = 50;
       // int secondPlayerScore = 70;
        //int thirdPlayerScore = 100;
        
        //push  a new player score into stack
        stack.Push(cube);
        stack.Push(capsule);
       
        //show info in stack
        ShowInformationInStack(stack);
        //pop player score from stack
        stack.Pop();
        ShowInformationInStack(stack);
        //pop player score from stack
        stack.Pop();


    }

    void ShowInformationInStack(Stack stack)
    {
        //stackDebug.text += ".....\n";
        foreach (GameObject stackitem in stack)
        {

            i=i+2;
            j = j + 2;
            //Debug.Log(stack.Count);
            //stackDebug.text = "\n";
            //stackDebug.text += $"{stackitem}\n";
            Instantiate(stackitem, transform.position+new Vector3(0,i,0 ),Quaternion.identity);
           // Instantiate(capsule, transform.position + new Vector3(0, j, 0), Quaternion.identity);
        }
    }




}