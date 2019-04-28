﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text time;
    public Text bestTime;
    public float startTime;
    bool Finish = false;

    // Start is called before the first frame update
    void Start() {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update() {
        if(Finish)
            return;
        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        time.text = minutes + ":" + seconds;
    }

    public void Finished() {
        Finish = true;
        bestTime.text = time.text;
    }
}
