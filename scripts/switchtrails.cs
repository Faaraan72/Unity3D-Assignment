using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchtrails : MonoBehaviour
{
    [SerializeField] private GameObject gb;
    public TrailRenderer tr;
    public Material[] m;
    


    // Start is called before the first frame update
    void Start()
    {
        tr = gb.GetComponent<TrailRenderer>();

    }
    public void red()
    {
        tr.material = m[0];
        Debug.Log("red");
    }
    public void blue()
    {
        tr.material = m[1]; Debug.Log("blue");
    }
    public void white()
    {
        tr.material = m[2]; Debug.Log("white");
    }



}
