﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        //测试背包
        if (Input.GetKeyDown(KeyCode.A))
        {
            int id = Random.Range(1,18);
            Inventory.Instance.StoreItem(id);
        }
    }
}
