using System.Collections.Generic;
using Doozy.Engine.UI;
using UnityEngine;

namespace Doozy.Examples
{
	public class E12PopupManagerScript : MonoBehaviour
	{
		[Header("Popup Settings")]
		public string PopupName;

		[Header("Achievements")]
		public List<AchievementData> Achievements;

		private UIPopup m_popup;

		public void ShowAchievement(int achievementId)
		{
		}

		public void ClearPopupQueue()
		{
		}
	}
}
