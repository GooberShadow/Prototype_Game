using UnityEngine;

public class Talk : MonoBehaviour
{
    public bool talking = false;
    public string message;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKey("e"))
        {
            talking = true;
        }
    }

        // Update is called once per frame
        void Update()
    {
        /*if (Input.GetKey("e"))
        {
            Debug.Log("I AM TALKING TO YOU");
        }*/

        if (talking == true)
        {
            Debug.Log(message);
            talking = false;
        }
        
    }
}
