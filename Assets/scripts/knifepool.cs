using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifepool : MonoBehaviour
{
    public int knifepoolsize = 5;
    private GameObject[] knives;
    private Vector2 startspawn;
    public GameObject knifefab;
    private float timesincelastspawn;
    public float spawnrate;
    public float knifemin = 1f;
    public float knifemax = 3.5f;
    private float spawnxpos = 10f;
    private int currentknife = 0;
    // Start is called before the first frame update
    void Start()
    {
        knives = new GameObject[knifepoolsize];

        startspawn = new Vector2(1000f, 1000f);
        for(int i = 0; i < knifepoolsize; i++)
        {
            knives[i] = Instantiate(knifefab, startspawn, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timesincelastspawn += Time.deltaTime;

        if(!evilwizard.instance.gameover && timesincelastspawn >= spawnrate)
        {
            timesincelastspawn = 0f;
            float spawnyposition = Random.Range(knifemin, knifemax);
            knives[currentknife].transform.position = new Vector2(spawnxpos, spawnyposition);
            currentknife++;

            if(currentknife >= knifepoolsize)
            {
                currentknife = 0;   
            }
        }
    }
}
