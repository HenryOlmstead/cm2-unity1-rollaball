using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Rotate cube on x axis
        transform.Rotate(new Vector3(0, 1, 0));
    }

    void OnTriggerEnter()
    {
        //Destroy cube when ball touches it
        Destroy(gameObject);
    }
}
