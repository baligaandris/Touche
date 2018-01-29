using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainSignalController : MonoBehaviour {
    float h = 0;
    float v = 0;
    public float speed;
    public int triggersImIn = 0;
    Vector3 lastPosition;
    Vector3 currentPosition;
    Vector3 vectorOfMovement;
    private GameObject lastTrigger;
    public bool player1 = true;
    //thomas' controls
    public float accelleration = 20;
    public float maxVelocity;
    public float rotationSpeed;
    private Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        currentPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        //moving
        if (player1)
        {
            float xAxis = Input.GetAxis("Horizontal");
            float yAxis = Input.GetAxis("Vertical");

            Accellerate(yAxis, -xAxis);

            //Rotate(transform, xAxis * rotationSpeed);
        }
        else
        {
            float xAxis = Input.GetAxis("Horizontal2");
            float yAxis = Input.GetAxis("Vertical2");

            Accellerate(yAxis, -xAxis);

            //Rotate(transform, xAxis * rotationSpeed);
        }

        //transform.Translate(new Vector3(h, v, 0));

        if (triggersImIn ==0)
        {
            vectorOfMovement = rb.velocity.normalized;
                //(currentPosition - lastPosition).normalized;
            //if (vectorOfMovement.magnitude ==0)
            //{
            //    if (player1)
            //    {
            //        vectorOfMovement = Vector3.right;
            //    }
            //    else
            //    {
            //        vectorOfMovement
            //    }
                  
            //}
            lastTrigger.GetComponent<ForceApplier>().ApplyForce(transform.position, vectorOfMovement);
            Debug.Log(vectorOfMovement.magnitude);
            Destroy(gameObject);
        }
        //this should always happen last
        lastPosition = currentPosition;
        currentPosition = transform.position;
    }
    public void EnterTrigger(GameObject triggeringLimb)
    {
        
            triggersImIn++;
        lastTrigger = triggeringLimb;
    }

    public void ExitTrigger()
    {
        
            triggersImIn--;
        
    }
    void ClampVelocity()
    {
        float x = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);
        float y = Mathf.Clamp(rb.velocity.y, -maxVelocity, maxVelocity);

        rb.velocity = new Vector2(x, y);
    }

    void Accellerate(float y,float x)
    {
        Vector2 force = new Vector2(0, 0);
        if (y != 0|| x!=0)
        {
            force = (transform.up * -y * accelleration)+(transform.right*x*accelleration);

        }
        rb.AddForce(force);
        ClampVelocity();
    }

    void Rotate(Transform t, float amount)
    {
        t.Rotate(0, 0, -amount);

    }
    public void setHeadTrigger(GameObject head) {
        lastTrigger = head;
    }
}
