using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneController : MonoBehaviour
{
    public float speed;
    public float verticalRange1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //create a variable that holds value of position (position will always be a Vector value!)
        Vector3 newPosition = transform.position;

        //press W key to move up
        if (Input.GetKey("w") && transform.position.y < verticalRange1)
        {
            newPosition.y += speed; //same as newPosition.y = newPosition.y + speed
        }

        //press S key to move down
        if (Input.GetKey("s") && transform.position.y > -verticalRange1)
        {
            newPosition.y -= speed; //same as newPosition.y = newPosition.y - speed
        }

        //update the current position to the new position
        transform.position = newPosition;
    }
}