using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GamePlayDetailController : MonoBehaviour
{
  public GameObject mapView;
  public GameObject mapViewButton;
  public GameObject selectModeView;
  public GameObject skipAdviceButton;

  public GameObject goal;

  public GameObject adviceView;
  public GameObject adviceButton;

  public GameObject keyDetailView;
  public GameObject keyDetailButton;

  private float timeLeft = 0;
  public static float selectedTime = 0;
  public Text timeText;
  // Start is called before the first frame update
  void Start()
  {
    selectModeView.SetActive(false);
  }


  // Update is called once per frame
  void Update()
  {
    if (timeLeft != 0)
    {
      timeLeft -= Time.deltaTime;
      DisplayTime(timeLeft);
    }

    if (timeLeft < 0)
    {
      timeLeft = 0;
    }
  }

  void DisplayTime(float timeToDisplay)
  {
    float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    float seconds = Mathf.FloorToInt(timeToDisplay % 60);

    timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
  }

  public void mapViewClose()
  {
    mapView.SetActive(false);
    mapViewButton.SetActive(false);
    keyDetailView.SetActive(true);
  }


  public void keyDetailViewClose()
  {
    keyDetailView.SetActive(false);
    keyDetailButton.SetActive(false);
    adviceView.SetActive(true);
  }

  public void adviceViewClose()
  {
    adviceView.SetActive(false);
    adviceButton.SetActive(false);
    selectModeView.SetActive(true);
    skipAdviceButton.SetActive(false);
  }

  public void skipAllAdvice()
  {
    adviceView.SetActive(false);
    keyDetailView.SetActive(false);
    mapView.SetActive(false);
    skipAdviceButton.SetActive(false);
    selectModeView.SetActive(true);
  }
  public void setTimeLeft(float time)
  {
    timeLeft = time;
    selectedTime = time;
    selectModeView.SetActive(false);
  }

  public void LoadScene(string sceneName)
  {
    SceneManager.LoadScene(sceneName);
  }

}
