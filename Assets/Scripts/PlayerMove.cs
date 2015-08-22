using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public GameObject player;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveSpeed = Input.GetAxis ("Vertical");
		Debug.Log(moveSpeed);

	}
}
