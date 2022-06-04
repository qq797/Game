using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownController : MonoBehaviour
{
    public GameObject Player;

    public void ClickButtonDown()
    {
        Player.transform.position = Player.transform.position + new Vector3(0, 0, -0.20f);
    }

    bool press = false;
    public void OnDown()
    {
        press = true;
    }

    public void OnUp()
    {
        press = false;
    }

    public void Update()
    {
        if (press)
            ClickButtonDown();
    }

}