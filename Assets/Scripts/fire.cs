using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject ammo;
    bool firing = false;
    float counter = 0f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firing = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            firing = false;
        }
        if (firing)
        {
            counter += Time.deltaTime;
            if (counter >= 0.1f)
            {
                Instantiate(ammo, transform.position, transform.rotation);
                counter = 0;
            }
        }
    }
}
