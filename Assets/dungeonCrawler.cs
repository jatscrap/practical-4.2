using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dungeonCrawler : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position; //save the offset between the camera and the target object when the script starts
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = target.transform.position + offset; //update the camera position every frame to retain offset
        newPos.y = newPos.y + speed; //make camera position 10 higher
        transform.position = newPos;
        //search the rigid body folder for the velocity
        speed = target.GetComponent<Rigidbody>().velocity.magnitude; //get the speed of the car, multiply by 10

    }
}
