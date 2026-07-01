using System.Collections.Generic;
using UnityEngine;

namespace FavoritesTabs
{
	[ExecuteAlways]
	public class FG_GameObjectGUIDs : MonoBehaviour
	{
		public static bool _dirty;

		public static HashSet<FG_GameObjectGUIDs> allInstances;

		[SerializeField]
		[HideInInspector]
		public List<string> guids;

		[SerializeField]
		[HideInInspector]
		public List<Object> objects;

		public static void Test()
		{
		}

		protected FG_GameObjectGUIDs()
		{
		}

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void OnDestroy()
		{
		}
	}
}
