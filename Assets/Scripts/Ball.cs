using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    Rigidbody rigidBody;

    Vector3 ballOrigin;

	// Use this for initialization
	void Start ()
	{
	    rigidBody = GetComponent<Rigidbody>();
	    ballOrigin = transform.position; // store the original position of the ball so we reset at that place

	    ResetBall();
	}

    void ResetBall()
    {
        transform.position = ballOrigin;
        rigidBody.velocity = new Vector3(Random.value, 0, Random.value).normalized * 50;
    }

    void OnCollisionEnter(Collision col)
    {
        
    }
}
