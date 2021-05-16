using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DetailIntroController : MonoBehaviour
{

  public TextMeshProUGUI textDisplay;
  public string[] sentences;
  private int index;
  public float typingSpeed;

  public GameObject nextButton;
  public GameObject startButton;

  public
  // Start is called before the first frame update
  void Start()
  {
    StartCoroutine(Type());
  }

  void Update()
  {
    if (textDisplay.text == sentences[index])
    {
      nextButton.SetActive(true);
    }
  }


  IEnumerator Type()
  {
    nextButton.SetActive(false);
    foreach (char letter in sentences[index].ToCharArray())
    {
      textDisplay.text += letter;
      yield return new WaitForSeconds(typingSpeed);
    }
  }

  public void NextSectence()
  {
    if (index < sentences.Length - 1)
    {
      index++;
      textDisplay.text = "";
      StartCoroutine(Type());
    }
    else if (index == sentences.Length - 1)
    {
      nextButton.SetActive(false);
      startButton.SetActive(true);
    }
    else
    {
      textDisplay.text = "";
    }
  }

  public void LoadScene(string sceneName)
  {
    SceneManager.LoadScene(sceneName);

  }

}
