using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text CounterText;
    public Text WinText;
    public Text LooseText;
    public bool isGameOver;
    public List<GameObject> sphere;
    [SerializeField] public int pts;
    public Button restartButton;
    bool p;
    public bool isClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        pts = 0;
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void UpdatePoints(int point)
    {
        //Debug.Log(point);
        pts += point;
        CounterText.text = "Points : " + pts;
        //Debug.Log(p);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame(bool pred)
    {
        isGameOver = false;
        p = pred;
        for (int index = 0; index <= 30; index++)
        {
            Instantiate(sphere[index]);
        }
    }

    public void Gameover()
    {
        isGameOver = true;
        if (pts < 75 && p == true)
        {
            WinText.gameObject.SetActive(true);
            Debug.Log(p);
        }
        else if (pts < 75 && p != true)
        {
            LooseText.gameObject.SetActive(true);
            Debug.Log(p);
        }
        else if (pts > 75 && p != true)
        {
            WinText.gameObject.SetActive(true);
            Debug.Log(p);
        }
        else if (pts > 75 && p == true)
        {
            LooseText.gameObject.SetActive(true);
            Debug.Log(p);
        }
        restartButton.gameObject.SetActive(true);
        isClicked = false;
    }
}
