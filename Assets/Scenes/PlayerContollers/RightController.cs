using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightController : MonoBehaviour
{
    public GameObject Player;

    public void ClickButtonRight()
    {
        Player.transform.position = Player.transform.position + new Vector3(0.20f, 0, 0);
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
            ClickButtonRight();
    }

}