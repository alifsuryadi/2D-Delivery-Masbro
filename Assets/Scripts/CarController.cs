using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    //Serializefield bisa ubah value dalam bentuk private
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float carSpeed = 15f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 25f;

    
    void Update()
    {
        //Bikin supaya bisa di gerakan
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime ; //deltaTime = samakan kecepatannya
        float carSpeedAmout = Input.GetAxis("Vertical") * carSpeed * Time.deltaTime ;

        

        transform.Rotate(0, 0, -steerAmount ); //- supaya sesuai dengan panah
        transform.Translate(0, carSpeedAmout, 0);



    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        carSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boost")
        {
            carSpeed = boostSpeed;
            Destroy(collision.gameObject);
        }
        
    }


}
