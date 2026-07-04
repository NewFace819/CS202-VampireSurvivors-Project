using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.UI;

namespace VampireSurvivors
{
	public class VCLaunchCountdownUI : MonoBehaviour
	{
		private enum CountdownState
		{
			Uninitialized = 0,
			BeforeCountdown = 1,
			DuringCountdown = 2,
			DuringLaunchWindow = 3,
			AfterLaunchWindow = 4
		}

		[SerializeField]
		private MainMenuPage MainMenu;

		[SerializeField]
		private Selectable MainMenuPlayButton;

		[Space]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private CanvasGroup _countdownCanvasGroup;

		[SerializeField]
		private CanvasGroup _playNowCanvasGroup;

		[SerializeField]
		private Image _countdownRadialFillImage;

		[SerializeField]
		private Transform _countdownClockHandTransform;

		[SerializeField]
		private TextMeshProUGUI _countdownText;

		private readonly DateTime _countdownStartTime;

		private readonly DateTime _crawlersLaunchTime;

		private readonly DateTime _launchEndTime;

		private const string ClosedCountdownPrefsKey = "ClosedCrawlersCountdown";

		private const string LinkToSteamPage = "https://store.steampowered.com/app/3265700/?utm_source=vampire_survivors&utm_medium=pc_in_game_button&utm_campaign=vc_launch";

		private CountdownState _currentCountdownState;

		private bool ClosedCountDown => false;

		private bool ClosedPlayNow => false;

		private DateTime CountdownStartTime => default(DateTime);

		private DateTime CrawlersLaunchTime => default(DateTime);

		private DateTime LaunchEndTime => default(DateTime);

		private void Start()
		{
		}

		private void SetInitialState()
		{
		}

		private void ChangeState(CountdownState newState)
		{
		}

		private void Update()
		{
		}

		public void OnCloseCountdownButtonClicked()
		{
		}

		public void OpenCrawlersPopup()
		{
		}

		private void UpdateCountdownVisuals(DateTime timeNow)
		{
		}

		private void SetCanvasGroupActive(CanvasGroup canvasGroup, bool isActive)
		{
		}
	}
}
