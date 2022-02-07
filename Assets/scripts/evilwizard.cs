using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class evilwizard : MonoBehaviour
{
    public GameObject gameovertext;
    public bool gameover = false;

    public TextMeshProUGUI scoretext;

    private int score = 0;

    public static evilwizard instance;

    void Awake()
    {
        if(instance == null)
            instance = this;
        else if(instance != this)
            Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameover && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void turtleScored()
    {
        if(gameover)
        {
            return;
        }
        score++;
        scoretext.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        gameovertext.SetActive(true);
        gameover = true;
    }
}
