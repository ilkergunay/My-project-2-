using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopFirlat : MonoBehaviour
{
    [SerializeField] private Vector3 basPos;
    [SerializeField] private float basGucu=100f;
    private void OnMouseDown() {
        basPos=transform.position;
        GetComponent<LineRenderer>().enabled=true;
    }
    private void OnMouseDrag() {
        Vector3 kameraPos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position=new Vector3(kameraPos.x,kameraPos.y,0f);
    }
    private void OnMouseUp() {
        Vector3 uzunluk=basPos-transform.position;
        GetComponent<Rigidbody2D>().AddForce(uzunluk*basGucu);
        GetComponent<Rigidbody2D>().gravityScale=0;
        GetComponent<LineRenderer>().enabled=false;
    }
    void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0,transform.position);
        GetComponent<LineRenderer>().SetPosition(1,basPos);
    }
}
