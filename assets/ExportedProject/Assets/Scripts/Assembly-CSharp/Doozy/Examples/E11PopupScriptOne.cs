using UnityEngine;
using UnityEngine.UI;

namespace Doozy.Examples
{
	public class E11PopupScriptOne : MonoBehaviour
	{
		[Header("Popup Settings")]
		public string PopupName;

		public string Title;

		public string Message;

		[Space(10f)]
		public bool HideOnBackButton;

		public bool HideOnClickAnywhere;

		public bool HideOnClickOverlay;

		public bool HideOnClickContainer;

		[Header("Settings Controls")]
		public InputField TitleInput;

		public InputField MessageInput;

		[Space(10f)]
		public Toggle BackButtonToggle;

		public Toggle ClickAnywhereToggle;

		public Toggle ClickOverlayToggle;

		public Toggle ClickContainerToggle;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ShowPopup()
		{
		}
	}
}
