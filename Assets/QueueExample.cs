using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QueueExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI queueDebug;
     void Start()
    {
        Queue queue = new Queue();
        queue.Enqueue("x");
        queue.Enqueue("y");
        queue.Enqueue("z");
        queue.Enqueue("a");
        queue.Enqueue("b");
        ShowInformationInQueue(queue);
        queue.Dequeue();
        ShowInformationInQueue(queue);



    }
    private void ShowInformationInQueue(Queue queue)
    {
        queueDebug.text += ".......";
        foreach(var queueitem in queue)

        {
            Debug.Log(queue.Count);
            //stackDebug.text = "\n";
            queueDebug.text += $"{queueitem}\n";
        }
    }
}
