using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float speed = 0f;
    float rotspeed = 0f;
    public GameObject rearwheel1;
    public GameObject rearwheel2;
    public GameObject backwheel1;
    public GameObject backwheel2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            speed = -10f;
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            speed = 0f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed = 10f;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            speed = 0f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rotspeed = -10f;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rotspeed = 0f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rotspeed = 10f;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rotspeed = 0f;
        }
        transform.Translate(transform.forward * 1 * speed * Time.deltaTime, Space.World);
        rearwheel1.transform.Rotate(new Vector3(0f,0f,rotspeed) * Time.deltaTime, Space.Self);
        rearwheel2.transform.Rotate(new Vector3(0f, 0f, rotspeed) * Time.deltaTime, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("walls") || collision.gameObject.tag.Equals("lamps"))
        {
            speed = 0f;
        }
    }
}
