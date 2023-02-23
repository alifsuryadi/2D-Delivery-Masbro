using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Collision = memberitahu ada tabrakan
public class Collision : MonoBehaviour
{
    //sudah ambil paket atau tidak
    //default bool = false
    bool hasPackage;

    [SerializeField] Color32 hasPackageColor = new Color32(1, 0, 0, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] float delayPackage = 1f;

    //GetComponent
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package")
        {
            if (!hasPackage)
            {
                Debug.Log("Masbro picked up");
                hasPackage = true;
                spriteRenderer.color = hasPackageColor;
                Destroy(collision.gameObject, delayPackage);
                

            }
            else
            {
                Debug.Log("Package is full");
            }
        }
       
        if(collision.tag == "Costumer" && hasPackage)
        {
            Debug.Log("Delivered Package");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
        
    }
}
