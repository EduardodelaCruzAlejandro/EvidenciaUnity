using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeBullet : MonoBehaviour
{
    public float speed = 2f;

    public float lifeTime = 2f;

    private void Start()
    {
            Destroy(gameObject,lifeTime);
    }

    private void Update()
    {
            transform.Translate(Vector2.down * speed *Time.deltaTime);
    }
}
