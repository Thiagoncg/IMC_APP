using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMobController : MonoBehaviour
{

    //PRIVATE VARIABLES
    private BannerView bannerView;
    
    // Start is called before the first frame update
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
         this.RequestBanner();
    } 

    private void RequestBanner()
    {
        // esta usando o mesmo que o do Android, atualizar case crie para Unity
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-5382594268641960/9028876810";
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
}
