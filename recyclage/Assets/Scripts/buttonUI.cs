using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Linq;

public class buttonUI : MonoBehaviour
{
    [SerializeField] public string nextLevel = "Level 1";
    private int selectedLevel = 0;

    public void nextLevelButton()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void Start()
    {
        string m_path = Application.dataPath + "/Scenes/";
        string[] files = Directory.GetFiles(m_path);
        for(int i = 0; i < files.Length;i++)
            print(files[i]);

        print(files.Length);
    }
}
