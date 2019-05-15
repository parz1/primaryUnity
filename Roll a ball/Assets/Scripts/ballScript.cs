using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballScript : MonoBehaviour {

    private Rigidbody rd;

    public int force = 5;
    private int score = 0;
    public Text text;
    public GameObject winText;

	// Use this for initialization
	void Start () {
        rd = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rd.AddForce(new Vector3(h, 0, v)*force);
	}

	private void OnTriggerEnter(Collider other)
	{
		
		if (other.tag=="Food")
		{
			score++;
			text.text = score.ToString();
			if (score == 4)
			{
				winText.SetActive(true);
			}
			Destroy(other.gameObject);
		}
	}

	//触发检测
	private void OnCollisionEnter(Collision other)
	{
		//string name = other.collider.name;
		//print(name);
		if (other.collider.tag=="Food")
		{
			Destroy(other.gameObject);
		}
	}
}
