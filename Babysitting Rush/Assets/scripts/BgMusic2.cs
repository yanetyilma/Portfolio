﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMusic2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private static BgMusic2 instance = null;
    public static BgMusic2 Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}