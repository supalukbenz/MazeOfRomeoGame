using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalController : MonoBehaviour
{
  public TextMeshProUGUI textDisplay;
  public GameObject nextButton;

  public GameObject playAgainButton;
  public GameObject exitButton;
  private string[] sentences;
  private int index;
  public float typingSpeed;
  // Start is called before the first frame update
  void Start()
  {
    StartCoroutine(Type());
  }

  // Update is called once per frame
  void Update()
  {
    if (textDisplay.text == sentences[index])
    {
      nextButton.SetActive(true);
    }
  }


  IEnumerator Type()
  {
    // float selectedTime = GamePlayDetailController.selectedTime;
    float selectedTime = 480;
    if (selectedTime == 480)
    {
      sentences = new string[] { "Juliet: You're so late, Romeo.", "Romeo: I love you, Juliet...", "Juliet: I love you too but you need to hurry back before the sun rises.", "Romeo: Tomorrow I will come again, wait for me, Juliet..." };
    }

    if (selectedTime == 300)
    {
      sentences = new string[] { "Juliet: You came at just the right time, Romeo.", "Romeo: I deeply in love with you, Juliet...", "Romeo: By the time the two families are reconciled, will you marry me?", "Juliet: Of course my love, I love you." };
    }

    if (selectedTime == 120)
    {
      sentences = new string[] { "Juliet: You have shown me how you love me.", "Juliet: All my life I was born to meet and love you, Romeo", "Romeo: I don't know how to live without you, Juliet...", "Romeo: Leaving our last names. Let's run away together now.", "Juliet: Oh my Romeo, from heaven to earth, I will only love you. Let's go hurry." };
    }

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
      playAgainButton.SetActive(true);
      exitButton.SetActive(true);
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
