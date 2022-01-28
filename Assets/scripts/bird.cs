using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float upforce = 200.0f;
    private bool isdead = false;
    private Animator anim;
    public ParticleSystem psys;
    private SpriteRenderer srenderer;
    public AudioSource[] sources;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        srenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isdead)
        {
            if(Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.zero;
                anim.SetTrigger("Flap");
                rb.AddForce(new Vector2(0f, upforce));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        sources[0].Stop();
        sources[1].PlayOneShot(sources[1].clip);
        rb.velocity = Vector2.zero;
        evilwizard.instance.BirdDied();
        srenderer.enabled = false;
        psys.Play();
        isdead = true;
    }
}
