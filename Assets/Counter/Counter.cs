using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    private GameManager gameManager;
    public int Count;
    private int Ct = 0;
    private void Start()
    {
        Count = 0;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Box 2"))
        {
            Count = 1;
            gameManager.UpdatePoints(Count);       
        }
       if (gameObject.CompareTag("Box 1"))
        {
            Count = 2;
            gameManager.UpdatePoints(Count);
        }
       if (gameObject.CompareTag("Box"))
        {
            Count = 3;
            int x = Random.Range(0, 3);
            Count *= x;
            gameManager.UpdatePoints(Count);
        }
        if (gameObject.CompareTag("Floor"))
        {
            Ct += 1;
            if (Ct == 31)
            {
                gameManager.Gameover();
                gameManager.isGameOver = true;
            }
          //  Debug.Log("ct" + Ct);
        }

    }

}
