using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public Vector3 moveDistance;

    private void Start()
    {
        moveDistance = new Vector3(1f, 0f, 0f)*Time.deltaTime;
    }

    private void Update()
    {
        this.gameObject.transform.Translate(moveDistance, Space.World);
        this.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor") { } else
        {
        moveDistance = -moveDistance;

        }
    }
}
