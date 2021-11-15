using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuKontrol : MonoBehaviour
{
    public GameObject menu;
    public void Durdur()
    {
        Time.timeScale=0;
        menu.SetActive(true);
    }
    public void GeriDon()
    {
        Time.timeScale=1;
        menu.SetActive(false);
    }
}
