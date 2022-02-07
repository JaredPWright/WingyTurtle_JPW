using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingobject : MonoBehaviour
{
    private Rigidbody2D rb;
    public float scrollspeed = -1.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(scrollspeed, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(evilwizard.instance.gameover)
        {
            rb.velocity = new Vector2(0f, 0.0f);
        }
    }
}
