using System;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.UI;

public class VCDemoScript : MonoBehaviour
{
	[SerializeField]
	private MainMenuPage MainMenu;

	[SerializeField]
	private Image Banner;

	[SerializeField]
	private Sprite Banner1;

	[SerializeField]
	private Sprite Banner2;

	[SerializeField]
	private Sprite Banner3;

	[SerializeField]
	private Sprite Banner4;

	[SerializeField]
	private GameObject Flare;

	[SerializeField]
	private Image FlareImage;

	[SerializeField]
	private GameObject WishlistNow;

	[SerializeField]
	private GameObject DemoNow;

	[SerializeField]
	private Button ButtonToSelect;

	[SerializeField]
	private AnimationCurve FlareAlphaCurve;

	[SerializeField]
	private AnimationCurve NextBannerAlphaCurve;

	[SerializeField]
	private AnimationCurve PrevBannerAlphaCurve;

	[SerializeField]
	private GameObject FlareStartPos;

	[SerializeField]
	private GameObject FlareEndPos;

	[SerializeField]
	private float AnimationTotalTime;

	[SerializeField]
	private float pointInAnimToSwapBanner;

	[SerializeField]
	private float TimeBetweenAnimations;

	private Sprite prevBanner;

	private Sprite NextBanner;

	private float animationTimer;

	private bool runningAnimation;

	private DateTime DemoLiveUTCTime;

	private DateTime CountdownLiveUTCTime;

	private float timeToStartNextAnim;

	private bool notSwappedBanner;

	private void Start()
	{
	}

	public void closeCrawlersPopup()
	{
	}

	public void OpenCrawlersPopup()
	{
	}

	public void StartAnimation()
	{
	}

	private void Update()
	{
	}
}
