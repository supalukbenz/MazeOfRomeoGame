using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
  public GameObject[] heartsCollection;
  public int objCount = 0;
  // Start is called before the first frame update
  void Start()
  {
    objCount = 0;
    while (objCount < 22)
    {
      heartsCollection[objCount].SetActive(false);
      objCount++;
    }
    int objNum = 0;
    int randomCount = 0;
    while (randomCount < 5)
    {
      objNum = Random.Range(0, 22);
      heartsCollection[objNum].SetActive(true);
      randomCount++;
    }

  }

  // Update is called once per frame
  void Update()
  {

  }
}
