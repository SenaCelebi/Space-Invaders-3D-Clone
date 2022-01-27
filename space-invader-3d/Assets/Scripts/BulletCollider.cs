using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.name == "Bullet(Clone)")
        {
            if (other.gameObject.tag == "Enemy")
            {
                Score.Instance.score += 50;
                Score.Instance.totalEnemy -= 1;
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
            else if (other.gameObject.name != "Player")
            {
                Destroy(gameObject);
            }
        }else if(gameObject.name == "EnemyBullet(Clone)")
        {
            if (other.gameObject.name == "Player")
            {
                Destroy(gameObject);
                Score.Instance.totalHealth -= 1;
            }
        }
        
    }

}
