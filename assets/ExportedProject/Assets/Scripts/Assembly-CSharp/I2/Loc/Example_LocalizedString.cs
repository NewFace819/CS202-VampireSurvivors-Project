using UnityEngine;

namespace I2.Loc
{
	public class Example_LocalizedString : MonoBehaviour
	{
		public LocalizedString _MyLocalizedString;

		public string _NormalString;

		[TermsPopup(null)]
		public string _StringWithTermPopup;

		public void Start()
		{
		}
	}
}
