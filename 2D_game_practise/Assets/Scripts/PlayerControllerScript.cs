using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {
    [SerializeField] private Transform cursorObject;
    [SerializeField] private float playerSpeed = 10;

    private Rigidbody2D playerRigidbody;
    
	void Start () {
        playerRigidbody = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        Move();	
	}

    private void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 direction = cursorObject.position - transform.position;
            playerRigidbody.velocity = direction*playerSpeed*Time.deltaTime;
        }
        else
        {
            playerRigidbody.velocity = Vector2.zero;
        }
    }
}
