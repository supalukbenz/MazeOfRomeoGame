using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalController : MonoBehaviour
{

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
    Debug.Log(gameObject.name + " was triggered by " + other.gameObject.name);
    if (other.gameObject.tag == "Person") ;
    {
      Debug.Log(gameObject.name + " was triggered by " + other.gameObject.name);
      SceneManager.LoadScene("FinalScene");
    }
  }

}
