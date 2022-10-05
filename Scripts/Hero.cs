using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using GoogleMobileAds;
using GoogleMobileAds.Api;

public class Hero : MonoBehaviour
{
    public static int score;
    public Text txt;
    public static float time = 1f;
    public static int over;
    public GameObject panel;

    public int scoreads; // счетчике для рекламы
    public InterAd interAd;

    void Start()
    {
        scoreads = PlayerPrefs.GetInt("scoreads", scoreads);
        over = 0;
        StartCoroutine(Scoree());
    }

    void Update()
    {
        txt.text = score.ToString() + " ";
    }

    IEnumerator Scoree()
    {
        while (over == 0)
        {          
            yield return new WaitForSeconds(time);
            score++;
        }
    }

    void OnCollisionEnter2D(Collision2D coll) // соприкосновение с другим колайдером
    {
        if (coll.gameObject.tag == "Finish")
        {
            over = 1;

            if (PlayerPrefs.GetString("Music") == "yes" && over == 1)
                GameObject.Find("End").GetComponent<AudioSource>().Play();

            panel.SetActive(true);

            scoreads++; //счетчик рекламы
            PlayerPrefs.SetInt("scoreads", scoreads); //записали в реестр
            if (PlayerPrefs.GetInt("scoreads") % 5 == 0) interAd.ShowAd(); // показали рекламу
        }

        if (PlayerPrefs.GetInt("Record") < score) //обновление рекорда
            PlayerPrefs.SetInt("Record", score);
    }
}
