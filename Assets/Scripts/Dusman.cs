using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dusman : MonoBehaviour
{
    public float max=0;
    public float min=0;
    public bool x;
    public bool y;
    public float yon=1;
    public Rigidbody2D rb;
    public float hiz=0;

    public float can=0;
    void Start()
    {
        rb=this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var pos=transform.position;
        if(pos.x==min || pos.x==max) { yon=yon*-1;}
        if(x)
        {
            pos.x=Mathf.Clamp(pos.x,min,max);
            rb.velocity=new Vector2(Time.deltaTime*hiz*yon,0);
        }
        if(pos.y==min || pos.y==max) { yon=yon*-1;}
        if(y)
        {
            pos.y=Mathf.Clamp(pos.y,min,max);
            rb.velocity=new Vector2(0,Time.deltaTime*hiz*yon);
        }
        pos.z=0;
        this.transform.position=pos;
    }
    public Text txt;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="playerTop")
        {
            can=can-10;
            txt.text=can.ToString();
        }
    }
}
