using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pause : MonoBehaviour
{

    [SerializeField] TMP_Text pauseText;
    [SerializeField] Button mainMenuButton;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && Time.timeScale != 0)
        {
            Time.timeScale = 0;
            pauseText.text = "En Pause!";
            mainMenuButton.gameObject.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && Time.timeScale != 1)
        {
            Time.timeScale = 1;
            pauseText.text = "";
            mainMenuButton.gameObject.SetActive(false);
        }
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
