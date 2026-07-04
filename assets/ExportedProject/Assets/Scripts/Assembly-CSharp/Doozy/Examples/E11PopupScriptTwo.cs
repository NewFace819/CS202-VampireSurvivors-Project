using Doozy.Engine.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Doozy.Examples
{
	public class E11PopupScriptTwo : MonoBehaviour
	{
		[Header("Popup Settings")]
		public string PopupName;

		public string Title;

		public string Message;

		[Space(10f)]
		public string LabelButtonOne;

		public string LabelButtonTwo;

		public bool HideOnButtonOne;

		public bool HideOnButtonTwo;

		[Header("Settings Controls")]
		public InputField TitleInput;

		public InputField MessageInput;

		[Space(10f)]
		public InputField LabelButtonOneInput;

		public InputField LabelButtonTwoInput;

		public Toggle ButtonOneToggle;

		public Toggle ButtonTwoToggle;

		private UIPopup m_popup;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ShowPopup()
		{
		}

		private void ClickButtonOne()
		{
		}

		private void ClickButtonTwo()
		{
		}

		private void ClosePopup()
		{
		}
	}
}
