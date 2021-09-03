using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QueueExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI queueDebug;
    public GameObject cube;
    public GameObject capsule;
    int i = 0;
    int j = 1;

    void Start()
    {
        Queue queue = new Queue();
        queue.Enqueue(cube);
        queue.Enqueue(capsule);
      //  queue.Enqueue("z");
       // queue.Enqueue("a");
       // queue.Enqueue("b");
        ShowInformationInQueue(queue);
        queue.Dequeue();
        ShowInformationInQueue(queue);



    }
    private void ShowInformationInQueue(Queue queue)
    {
        //queueDebug.text += ".......";
        foreach(GameObject queueitem in queue)

        {
            i = i + 2;
            j = j + 2;
            // Debug.Log(queue.Count);
            //stackDebug.text = "\n";
            Instantiate(queueitem, transform.position + new Vector3(0, i, 0), Quaternion.identity);
          //  queueDebug.text += $"{queueitem}\n";
        }
    }
}
