using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour {

    private Rigidbody2D rigid;
    private float Speed = 2.0f;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        playerInput();
	}

    private void playerInput()
    {
        float vel = Input.GetAxis("Horizontal") * Speed;
        rigid.velocity = new Vector2(vel, rigid.velocity.y);
    }
}
