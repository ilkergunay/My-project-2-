using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rastgele : MonoBehaviour
{
    public GameObject[] prefabs;
    void Start()
    {
        InvokeRepeating("olustur",0.1f,0.3f);
    }
    void olustur()
    {
        float px=Random.Range(-8f,8f);
        int salla=Random.Range(0,prefabs.Length);
        var x=Instantiate(prefabs[salla],new Vector3(px,16,0),Quaternion.identity);
    }
}
