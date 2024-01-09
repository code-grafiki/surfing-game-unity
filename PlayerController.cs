using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float torque;
    [SerializeField] float BoostSpeed;
    [SerializeField] float BaseSpeed;
    SurfaceEffector2D surfaceEffector2D;
    bool CanMove = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CanMove)
        {
        RotatePlayer();
        RespondToBoost();
        }
    }

    public void DisableControls()
    {
        CanMove = false;
    }
    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = BoostSpeed;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            surfaceEffector2D.speed = BaseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torque);
        }
    }
}