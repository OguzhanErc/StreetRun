using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public UIManager uimanager;

    public GameObject Car1;
    public GameObject Car2;
    public GameObject Car3;
    public GameObject Car4;

    public Sprite YellowImage;
    public Sprite GreenImage;

    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;

    public GameObject Lock1;
    public GameObject Lock2;
    public GameObject Lock3;
    private void Awake()
    {

        if (PlayerPrefs.HasKey("itemselect") == false)
            PlayerPrefs.SetInt("itemselect", 0);

        //-----ITEM SELECT-----
        if (PlayerPrefs.GetInt("itemselect") == 0)
            Item1Open();
        else if (PlayerPrefs.GetInt("itemselect") == 1)
            Item2Open();
        else if (PlayerPrefs.GetInt("itemselect") == 2)
            Item3Open();
        else if (PlayerPrefs.GetInt("itemselect") == 3)
            Item4Open();


        //-----LOCKS-----
        if (PlayerPrefs.HasKey("lock1control") == false)
            PlayerPrefs.SetInt("lock1control", 0);

        if (PlayerPrefs.HasKey("lock2control") == false)
            PlayerPrefs.SetInt("lock2control", 0);

        if (PlayerPrefs.HasKey("lock3control") == false)
            PlayerPrefs.SetInt("lock3control", 0);




        if (PlayerPrefs.GetInt("lock1control") == 1)
            Lock1.SetActive(false);
        if (PlayerPrefs.GetInt("lock2control") == 1)
            Lock2.SetActive(false);
        if (PlayerPrefs.GetInt("lock3control") == 1)
            Lock3.SetActive(false);
    }
    public void Item1Open()
    {

        Car1.SetActive(true);
        Car2.SetActive(false);
        Car3.SetActive(false);
        Car4.SetActive(false);

        Item1.GetComponent<Image>().sprite = GreenImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 0);
    }
    public void Item2Open()
    {

        Car1.SetActive(false);
        Car2.SetActive(true);
        Car3.SetActive(false);
        Car4.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = GreenImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 1);
    }
    public void Item3Open()
    {

        Car1.SetActive(false);
        Car2.SetActive(false);
        Car3.SetActive(true);
        Car4.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = GreenImage;
        Item4.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 2);
    }
    public void Item4Open()
    {

        Car1.SetActive(false);
        Car2.SetActive(false);
        Car3.SetActive(false);
        Car4.SetActive(true);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = GreenImage;

        PlayerPrefs.SetInt("itemselect", 3);

    }


    //--------LOCKS--------


    public void Lock1Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock1control = PlayerPrefs.GetInt("lock1control");
        if (money >= 5000 && lock1control == 0)
        {
            Lock1.SetActive(false);

            PlayerPrefs.SetInt("moneyy", money - 5000);
            PlayerPrefs.SetInt("lock1control", 1);
            Item2Open();
            uimanager.CoinTextUpdate();
        }
    }
    public void Lock2Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock2control = PlayerPrefs.GetInt("lock2control");
        if (money >= 10000 && lock2control == 0)
        {
            Lock2.SetActive(false);

            PlayerPrefs.SetInt("moneyy", money - 10000);
            PlayerPrefs.SetInt("lock2control", 1);
            Item3Open();
            uimanager.CoinTextUpdate();
        }
    }
    public void Lock3Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock3control = PlayerPrefs.GetInt("lock3control");
        if (money >= 15000 && lock3control == 0)
        {
            Lock3.SetActive(false);

            PlayerPrefs.SetInt("moneyy", money - 15000);
            PlayerPrefs.SetInt("lock3control", 1);
            Item4Open();
            uimanager.CoinTextUpdate();
        }
    }

}
