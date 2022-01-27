using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float bordersX;
    public float speedX;

    public Rigidbody bullet;

    float time = 0;
    public float fireInterval;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        time = time + Time.deltaTime;

        float newX = 0;
        float touchX = 0;

        if (time > fireInterval)
        {
            Rigidbody spawnBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            spawnBullet.AddForce(Vector3.forward * 500);
            time = 0;
        }
       

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchX = Input.GetTouch(0).deltaPosition.x / Screen.width;
            

        }
        else if(Input.GetMouseButton(0))
        {
            touchX = Input.GetAxis("Mouse X");
           
        }

        newX = transform.position.x + speedX * touchX * Time.deltaTime;
        newX = Mathf.Clamp(newX, -3.3f, bordersX);

        Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z);
        transform.position = newPosition;

       


    }

 
}
