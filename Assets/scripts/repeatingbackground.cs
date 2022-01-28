using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingbackground : MonoBehaviour
{
    private BoxCollider2D coll2D;
    private float horizontallength;
    // Start is called before the first frame update
    void Start()
    {
        coll2D = GetComponent<BoxCollider2D>();
        horizontallength = coll2D.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < - horizontallength)
        {
            RepoGround();
        }
    }

    private void RepoGround()
    {
        Vector2 groundoffset = new Vector2(horizontallength * 2.0f, 0f);
        transform.position = (Vector2)transform.position + groundoffset;
    }
}
