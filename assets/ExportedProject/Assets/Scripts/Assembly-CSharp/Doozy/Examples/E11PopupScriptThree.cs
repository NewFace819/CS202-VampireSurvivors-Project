using Doozy.Engine.UI;
using UnityEngine;

namespace Doozy.Examples
{
	public class E11PopupScriptThree : MonoBehaviour
	{
		public enum PopupType
		{
			Error = 0,
			Info = 1,
			Warning = 2,
			Whatever = 3
		}

		[Header("Popup Settings")]
		public string PopupName;

		[Header("Error Popup Settings")]
		public Sprite ErrorSprite;

		public string ErrorTitle;

		public string ErrorMessage;

		public Color ErrorTextColor;

		[Header("Info Popup Settings")]
		public Sprite InfoSprite;

		public string InfoTitle;

		public string InfoMessage;

		public Color InfoTextColor;

		[Header("Warning Popup Settings")]
		public Sprite WarningSprite;

		public string WarningTitle;

		public string WarningMessage;

		public Color WarningTextColor;

		[Header("Whatever Popup Settings")]
		public Sprite WhateverSprite;

		public string WhateverTitle;

		public string WhateverMessage;

		public Color WhateverTextColor;

		private UIPopup m_popup;

		public void ShowPopup(PopupType popupType)
		{
		}

		public void ShowInfoPopup()
		{
		}

		public void ShowWarningPopup()
		{
		}

		public void ShowErrorPopup()
		{
		}

		public void ShowWhateverPopup()
		{
		}
	}
}
