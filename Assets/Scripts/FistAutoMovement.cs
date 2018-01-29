using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistAutoMovement : MonoBehaviour {

    public GameObject[] cyclePoints;

    public float cycleSpeed;
    public float returnSpeed;
    public int currentPointIndex = 0;
    public bool rest = true;
    float cooldown = 0;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //if (cooldown >0)
        //{
        //    cooldown -= Time.deltaTime;
        //}
        //else
        //{
        //    rest = true;
        //    GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        //}
        
        if (rest)
        {
            //transform.position = Vector3.MoveTowards(transform.position, cyclePoints[currentPointIndex].transform.position, cycleSpeed * Time.deltaTime);
            GetComponent<Rigidbody2D>().AddForce((cyclePoints[currentPointIndex].transform.position - transform.position)*100*Time.deltaTime);
            //if (transform.position == cyclePoints[currentPointIndex].transform.position)
            //{
            //    if (currentPointIndex < cyclePoints.Length - 1)
            //    {
            //        currentPointIndex++;
            //    }
            //    else
            //    {
            //        currentPointIndex = 0;
            //    }
            //}
        }
       
        if (Input.GetButtonDown("Jump"))
        {
            rest = false;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * 1000, ForceMode2D.Impulse);
            cooldown = 1f;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject==cyclePoints[currentPointIndex])
        {
            if (currentPointIndex < cyclePoints.Length - 1)
            {
                currentPointIndex++;
            }
            else
            {
                currentPointIndex = 0;
            }
        }
    }
}
