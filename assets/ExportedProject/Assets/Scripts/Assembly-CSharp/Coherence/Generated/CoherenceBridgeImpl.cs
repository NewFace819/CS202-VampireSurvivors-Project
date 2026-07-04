using Coherence.Core;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using UnityEngine;

namespace Coherence.Generated
{
	public class CoherenceBridgeImpl
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void OnRuntimeMethodLoad()
		{
		}

		private static uint AssetId()
		{
			return 0u;
		}

		private static (bool, SpawnInfo) GetSpawnInfo(IClient client, IncomingEntityUpdate entityUpdate, Coherence.Log.Logger logger)
		{
			return default((bool, SpawnInfo));
		}

		private static IDefinition GetRootDefinition()
		{
			return null;
		}

		private static ICoherenceComponentData CreateConnectionSceneUpdateInternal(uint sceneIndex, AbsoluteSimulationFrame simFrame)
		{
			return null;
		}

		private static IDataInteropHandler GetDataInteropHandler()
		{
			return null;
		}
	}
}
