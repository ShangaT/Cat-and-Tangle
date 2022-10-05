using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject hero;
    public int angle;
    public GameObject panel;
    public GameObject on;

    void Start()
    {
        PlayerPrefs.GetString("Music");
        if (PlayerPrefs.GetString("Music") == "yes") //проверка спрайта музыки
        {
            on.SetActive(true);
        }

        else
        {
            on.SetActive(false);          
        }
    }

    public void Rights ()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
            GameObject.Find("Tap").GetComponent<AudioSource>().Play();

        Vector3 point = new Vector3(0f, -2.6f, 0f); // задаем точку, вокруг которой вращаем
        hero.transform.RotateAround(point, Vector3.forward, -1 * angle * Time.deltaTime);
    }

    public void Left()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
            GameObject.Find("Tap").GetComponent<AudioSource>().Play();

        Vector3 point = new Vector3(0f, -2.6f, 0f);
        hero.transform.RotateAround(point, Vector3.forward, angle * Time.deltaTime);
    }

    public void Replay()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
            GameObject.Find("Clik").GetComponent<AudioSource>().Play();
        Hero.score = 0;
        SceneManager.LoadScene("Play");
    }

    public void Home()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
            GameObject.Find("Clik").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Start");
    }

    public void Exit()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
            GameObject.Find("Clik").GetComponent<AudioSource>().Play();
        Application.Quit();
    }

    public void How()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
            GameObject.Find("Clik").GetComponent<AudioSource>().Play();
        panel.SetActive(true);
    }

    public void Esp()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
            GameObject.Find("Clik").GetComponent<AudioSource>().Play();
        panel.SetActive(false);
    }

    public void MusicOff() // выключить музыку
    {
        if (PlayerPrefs.GetString("Music") == "yes")
            GameObject.Find("Clik").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetString("Music", "no");
        on.SetActive(false);      
    }

    public void MusicOn()
    {
        if (PlayerPrefs.GetString("Music") == "yes")
            GameObject.Find("Clik").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetString("Music", "yes");
        on.SetActive(true);
    }

    void OnGUI()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
