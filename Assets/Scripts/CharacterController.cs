using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

	public float speed = 25.0f;
	public float rotationSpeed = 180;
	public float force = 700f;
   // public Transform bulletSpawn;
   // public GameObject bulletPrefab;
	

	Rigidbody rb;
	Transform t;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		t  = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			rb.velocity += this.transform.forward * speed * Time.deltaTime;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			rb.velocity -= this.transform.forward * speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.D))
		{
			t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			t.rotation *= Quaternion.Euler(0, - rotationSpeed * Time.deltaTime, 0);
		}
        /*
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(t.up * force);
		}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
           //GameObject newBullet = GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
           // newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 10;
           // newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1500);
        }*/
    }//end Update


    /*
    void Fire()
    {
        var bullet = (GameObject)Instantiate(
                      bulletPrefab,
                      bulletSpawn.position,
                      bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }*/
}//end class
