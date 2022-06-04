using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpController : MonoBehaviour
{
    public GameObject Player;

    public void ClickButtonUp()
    {
        Player.transform.position = Player.transform.position + new Vector3(0, 0, 0.20f);
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
            ClickButtonUp();
    }

}