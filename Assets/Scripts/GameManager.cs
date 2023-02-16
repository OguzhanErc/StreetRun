using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uimanager;
    public AddManager addmanager;
    public CameraMove cameramove;
    public void Start()
    {
        CoinCalculator(0);
        Debug.Log(PlayerPrefs.GetInt("moneyy"));
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")&& gameObject.CompareTag("FinishLine"))
        {
            Debug.Log("GameFinished");
            if (PlayerPrefs.GetInt("Noads") == 0)
            {
                addmanager.RequestInterstitial();
            }            
            addmanager.RequestRewardedad();
            CoinCalculator(100);           
            uimanager.CoinTextUpdate();
            uimanager.FinishScreen();
            PlayerPrefs.SetInt("LevelIndex", PlayerPrefs.GetInt("LevelIndex") + 1);
            cameramove.Camera_Movement = true;
            

        }
    }
    public void CoinCalculator(int money)
    {
        if (PlayerPrefs.HasKey("moneyy"))
        {
            int oldscore = PlayerPrefs.GetInt("moneyy");
            PlayerPrefs.SetInt("moneyy",oldscore + money);

        }
        else
        {
            PlayerPrefs.SetInt("moneyy", 0);
        }
    }
    
}
