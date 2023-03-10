using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public TextMeshProUGUI loadingtext;
    public void Start()
    {
        if (PlayerPrefs.HasKey("LevelIndex")==false)
        {
            PlayerPrefs.SetInt("LevelIndex", 1);

        }
        StartCoroutine("LoadingBar");
        LevelControl();
    }

    public void LevelControl()
    {
        int level = PlayerPrefs.GetInt("LevelIndex");
        SceneManager.LoadSceneAsync(level);
    }
    public IEnumerator LoadingBar()
    {
        while (true)
        {

            loadingtext.text="Loading".ToString();
            yield return new WaitForSecondsRealtime(.5f);
            loadingtext.text = "Loading.".ToString();
            yield return new WaitForSecondsRealtime(.5f);
            loadingtext.text = "Loading..".ToString();
            yield return new WaitForSecondsRealtime(.5f);
            loadingtext.text = "Loading...".ToString();
        }
    }
   
}
