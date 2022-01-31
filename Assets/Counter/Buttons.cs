using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buttons : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public bool isBelow;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetPred);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetPred()
    {
        if (!gameManager.isClicked)
        {
            gameManager.StartGame(isBelow);
            gameManager.isClicked = true;
        }
    }
}
