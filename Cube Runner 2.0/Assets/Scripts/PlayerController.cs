using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public GameObject death;

	public float speed;
	public float turn_speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") != 0f)
        {
            rb.velocity = new Vector3(Input.GetAxis("Horizontal") * turn_speed, 0, speed);
        }
        else
            rb.velocity = new Vector3(rb.velocity.x, 0, speed);

	}

    public void Leftdown(){
        rb.velocity = new Vector3(-turn_speed, 0, speed);   
    }

    public void Leftup()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }

    public void Rightdown()
    {
        rb.velocity = new Vector3(turn_speed, 0, speed);
    }

    public void Rightup()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }


	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Enemy")
		{
			Instantiate(death, this.transform.position, Quaternion.identity);
			this.GetComponent<MeshRenderer>().enabled = false;
			speed = 0;
			turn_speed = 0;
			GameManager.instance.alive = false;
            //print("hit");
            SceneManager.LoadScene("level");
		}
	}

}
