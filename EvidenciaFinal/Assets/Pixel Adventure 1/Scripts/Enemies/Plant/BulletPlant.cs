using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlant : MonoBehaviour
{
    public float speed = 2f;

    public float lifeTime = 2f;

    public bool left;


    private void Start()
    {
        Destroy(gameObject,lifeTime);
    }

    private void Update()
    {
        if (left)
        {
            transform.Translate(Vector2.left*speed*Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
