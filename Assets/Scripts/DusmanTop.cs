using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanTop : MonoBehaviour
{
    public GameObject[] prefabs;
    public float rnd;
    void Start()
    {
        rnd=Random.Range(0.001f,1f);
        print(rnd);
        InvokeRepeating("olustur",0.1f,rnd);
    }

    // Update is called once per frame
    void Update()
    {
        rnd=Random.Range(0.001f,1f);
    }
        void olustur()
    {
        //float px=Random.Range(-8f,8f);
        int salla=Random.Range(0,prefabs.Length);
        var x=Instantiate(prefabs[salla],this.transform.position,Quaternion.identity);
    }
}
