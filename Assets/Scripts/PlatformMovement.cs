using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public Transform[] puntosmoviles;
    public float platformSpeed = 2f;

    private int siguientePunto = 0;

    void Update()
    {
        if (puntosmoviles.Length == 0) return;

        Transform target = puntosmoviles[siguientePunto];
        transform.position = Vector3.MoveTowards(transform.position, target.position, platformSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            siguientePunto = (siguientePunto + 1) % puntosmoviles.Length;
        }
    }
    }

