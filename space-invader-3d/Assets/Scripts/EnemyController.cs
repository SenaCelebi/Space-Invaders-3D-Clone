using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private static bool moveLeft = false;
    private int time;
    private int timeTreshold;

    public Rigidbody enemyBullet;

    private void Start()
    {
        timeTreshold = Random.Range(50, 600);
        time = timeTreshold;
    }
    void Update()
    {
        if (moveLeft)
        {
            Vector3 newPosition = new Vector3(transform.position.x - 5 * Time.deltaTime, transform.position.y, transform.position.z);
            transform.position = newPosition;
           
        }
        else
        {
            Vector3 newPosition = new Vector3(transform.position.x + 5 * Time.deltaTime, transform.position.y, transform.position.z );
            transform.position = newPosition;
        }

        time -= 1;

        if(time < 2)
        {
            int randomNum = Random.Range(0, 5);
            int num = randomNum;

            if(num == 2)
            {
                Rigidbody spawnEnemyBullet = Instantiate(enemyBullet, transform.position, Quaternion.identity);
                spawnEnemyBullet.AddForce(-Vector3.forward * 500);
            }
            time = timeTreshold;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "BoundryLeft")
        {
            moveLeft = false;
        }
        else if (other.gameObject.name == "BoundryRight")
        {
            moveLeft = true;
        }
    }
}
