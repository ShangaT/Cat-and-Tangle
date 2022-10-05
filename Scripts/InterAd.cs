using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GoogleMobileAds;
using GoogleMobileAds.Api;

public class InterAd : MonoBehaviour
{
    private InterstitialAd ad;
    private string ads = "ca-app-pub-4570670889883763/5897492308";

    private void Start()
    {
        ad = new InterstitialAd(ads); // инициализация рекламы
        AdRequest adRequest = new AdRequest.Builder().Build(); //!!!
        ad.LoadAd(adRequest);
    }

    public void ShowAd()
    {
        if (ad.IsLoaded()) ad.Show();
    }
}
