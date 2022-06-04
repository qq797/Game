using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFieldController : MonoBehaviour
{
    public GameObject Player; // тут объект игрока
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
