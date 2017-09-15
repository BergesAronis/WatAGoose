using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody body;

    float rotY;
    public float moveSpeed = 10f;
    public float rotateSpeed = 100f;

    public KeyCode forward;
    public KeyCode backward;
    public KeyCode left;
    public KeyCode right;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(forward))
        {
            goForward();
        }
        else if (Input.GetKey(backward))
        {
            goBack();
        }
        if (Input.GetKey(left))
        {
            turnLeft();
        }
        else if (Input.GetKey(right))
        {
            turnRight();
        }
	}

    void goForward()
    {
        body.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void goBack()
    {
        body.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }

    void turnLeft()
    {
        rotY -= rotateSpeed * Time.deltaTime;
        body.transform.rotation = Quaternion.Euler(0, rotY, 0);
    }

    void turnRight()
    {
        rotY += rotateSpeed * Time.deltaTime;
        body.transform.rotation = Quaternion.Euler(0, rotY, 0);
    }
}
