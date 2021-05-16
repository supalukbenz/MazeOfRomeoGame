using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpecialReward : MonoBehaviour
{
  public GameObject player;
  public GameObject cameraTopView;
  public GameObject cam1;
  public GameObject cam2;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }


  void OnTriggerEnter(Collider other)
  {

    if (other.gameObject.tag == "Person") ;
    {
      Debug.Log(gameObject.name + " was triggered by " + other.gameObject.tag);
      cameraTopView.SetActive(true);
      gameObject.SetActive(false);
      player.SetActive(true);
      Debug.Log("Five");

      Invoke("ResetPositionCamera", 5);

    }
  }

  public void ResetPositionCamera()
  {
    Debug.Log("after Five");
    cameraTopView.SetActive(false);

    cam1.SetActive(false);
    player.SetActive(true);
    cam2.SetActive(true);
  }


}
