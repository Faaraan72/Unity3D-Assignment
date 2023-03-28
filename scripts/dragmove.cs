using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class dragmove : MonoBehaviour
{
    [SerializeField] private AudioSource a;
    [SerializeField]private AudioSource win;
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;

    private Rigidbody rb;

    public bool isShoot;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    private void OnMouseDown()
    {
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
        Shoot( mousePressDownPos - mouseReleasePos);
    }
    private int played = 0;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "win" && played==0)
        {
            win.Play();
            played++;
        }
    }

    private float forceMultiplier = 3;
    void Shoot(Vector3 Force)
    {
        if (isShoot)
            return;

        rb.AddForce(new Vector3(Force.x, Force.y, Force.y) * forceMultiplier);
        a.Play();
        isShoot = true;
    }

}