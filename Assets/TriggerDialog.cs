using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialog : MonoBehaviour
{
    public int index;
    public Transform gameManager;

    GameManagers gameManagerC;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerC = gameManager.GetComponent<GameManagers>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        gameManagerC.OnTriggerDialog(index);
    }
}
