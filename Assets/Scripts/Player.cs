using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float hizlandir=20f;
    public float arttir=0f;
    void Update()
    {
        Vector2 mousePosition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 kendiPosition= this.transform.position;
        transform.position=Vector3.MoveTowards(kendiPosition,new Vector3(mousePosition.x,transform.position.y,0),Time.deltaTime*hizlandir);
        var pos=transform.position;
        pos.x=Mathf.Clamp(pos.x,-8f,8f);
        transform.position=pos;

        // float x=Input.GetAxis("Horizontal")*Time.deltaTime*hizlandir;
        // transform.Translate(x,0,0);
        GameObject.FindWithTag("rekor").GetComponent<Text>().text = PlayerPrefs.GetFloat("Skor").ToString();


        topFirlat(mousePosition);
    }
    public float zaman=5f;
    public GameObject [] prefabs;
    public void topFirlat(Vector2 pos)
    {
        if(zaman>0)
        {
            zaman -=Time.deltaTime;
        }
        if(Input.GetMouseButtonDown(0))
        {
            int salla=Random.Range(0,prefabs.Length);
            var x=Instantiate(prefabs[salla],this.transform.position,Quaternion.identity);
        }
    }
    public AudioClip BoomSound;
    public GameObject[] patlama;
    private void OnTriggerEnter2D(Collider2D bul)
    {
        AudioSource.PlayClipAtPoint(BoomSound, bul.transform.position);
        if (bul.gameObject.tag=="top_b")
        {
            //Debug.Log("Top değdi");
            //print("Top değdi");
            Destroy(bul.gameObject);
            arttir++;
            Instantiate(patlama[0],bul.transform.position,Quaternion.identity);
        }
        if (bul.gameObject.tag=="top_y")
        {
            Destroy(bul.gameObject);
            arttir+=10;
            Instantiate(patlama[2],bul.transform.position,Quaternion.identity);
        }
        if (bul.gameObject.tag=="top_r")
        {
            Destroy(bul.gameObject);
            arttir-=10;
            Instantiate(patlama[1],bul.transform.position,Quaternion.identity);
        }
        if (arttir > PlayerPrefs.GetFloat("Skor"))
        {
            PlayerPrefs.SetFloat("Skor",arttir);
        }
            //GameObject.Find("Canvas/Text").GetComponent<Text>().text = arttir.ToString();
            GameObject.FindWithTag("skor").GetComponent<Text>().text = arttir.ToString();
    }
}
