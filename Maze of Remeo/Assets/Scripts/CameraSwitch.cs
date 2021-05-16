﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
  public GameObject cam1;  
  public GameObject cam2;
  public GameObject player;

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonDown("1Key"))
    {
      cam1.SetActive(true);
      player.SetActive(false);
      cam2.SetActive(false);
    }
    if (Input.GetButtonDown("2Key"))
    {
      cam1.SetActive(false);
      player.SetActive(true);
      cam2.SetActive(true);
    }
  }
}
