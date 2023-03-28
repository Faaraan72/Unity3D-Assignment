using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class retry : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 spawnpoint;
    public Rigidbody rb;
    public dragmove dg;



    public void Retrying()
    {
        rb.transform.position = spawnpoint;
        rb.velocity = new Vector3(0, 0, 0);
        dg.isShoot = false;

    }
    public void restarting()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
