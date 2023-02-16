using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource buttonSource;
    public AudioSource crashSource;
    public AudioSource cashSource;
    public AudioSource completeSource;


    public AudioClip buttonClip;
    public AudioClip crashClip;
    public AudioClip cashClip;
    public AudioClip completeClip;

    public void ButtonSound()
    {
        buttonSource.PlayOneShot(buttonClip);
    }
    public void CrashSound()
    {
        crashSource.PlayOneShot(crashClip);
    }
    public void CashSound()
    {
        cashSource.PlayOneShot(cashClip);
    }
    public void CompleteSound()
    {
        completeSource.PlayOneShot(completeClip);
    }
}
