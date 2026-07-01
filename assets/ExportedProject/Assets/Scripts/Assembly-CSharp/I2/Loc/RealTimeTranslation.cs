using System.Collections.Generic;
using UnityEngine;

namespace I2.Loc
{
	public class RealTimeTranslation : MonoBehaviour
	{
		private string OriginalText;

		private string TranslatedText;

		private bool IsTranslating;

		public void OnGUI()
		{
		}

		public void StartTranslating(string fromCode, string toCode)
		{
		}

		private void OnTranslationReady(string Translation, string errorMsg)
		{
		}

		public void ExampleMultiTranslations_Blocking()
		{
		}

		public void ExampleMultiTranslations_Async()
		{
		}

		private void OnMultitranslationReady(Dictionary<string, TranslationQuery> dict, string errorMsg)
		{
		}

		public bool IsWaitingForTranslation()
		{
			return false;
		}

		public string GetTranslatedText()
		{
			return null;
		}

		public void SetOriginalText(string text)
		{
		}
	}
}
