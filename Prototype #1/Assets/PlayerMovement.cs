using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, sidewaysForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -sidewaysForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}

/*using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool forward = false;
    bool backward = false;
    bool left = false;
    bool right = false;

    public float speed = 4;
    public Transform obj;
    public Vector3 tempVect;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;

        //obj.transform.position += tempVect;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        obj.transform.position += tempVect;
    }
}*/
