using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hizlandir : MonoBehaviour
{
    public float artis=-5.0f;
    private Rigidbody2D hiz;
    // Start is called before the first frame update
    void Start()
    {
        hiz = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //float x=transform.position.x;
        //float y=transform.position.y;
        hiz.velocity=new Vector3(0,artis,0);
    }
    public GameObject patlama;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="top_r")
        {
            
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(patlama,other.transform.position,Quaternion.identity);
        }
    }
}
