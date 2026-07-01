using System;
using UnityEngine;

namespace I2.Loc
{
	public class RegisterBundlesManager : MonoBehaviour, IResourceManager_Bundles
	{
		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public virtual UnityEngine.Object LoadFromBundle(string path, Type assetType)
		{
			return null;
		}
	}
}
