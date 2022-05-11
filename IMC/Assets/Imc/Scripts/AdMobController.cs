using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMobController : MonoBehaviour
{

    //PRIVATE VARIABLES
    private BannerView bannerView;
    private InterstitialAd interstitial;
    

    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
         this.RequestBanner();

         //Initialize Interstitial
         RequestInterstitial();
    } 

    private void RequestBanner()
    {//Banner na parte inferior aparece todo o tempo
        // esta usando o mesmo que o do Android, atualizar case crie para ios
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/6300978111";//ID TESTE
            //string adUnitId = "ca-app-pub-5382594268641960/9028876810";//ID REAL
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-5382594268641960/9028876810"; 
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd( request );
    }

    private void RequestInterstitial()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/1033173712";//ID TESTE
            //string adUnitId = "ca-app-pub-5382594268641960/8127864276";//ID REAL
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    public void ShowInterstitial()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }
}
