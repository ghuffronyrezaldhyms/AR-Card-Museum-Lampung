﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{
    void Start()
    {
        BGAudio.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}
