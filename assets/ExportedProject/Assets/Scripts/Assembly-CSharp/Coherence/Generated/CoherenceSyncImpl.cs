using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using UnityEngine;

namespace Coherence.Generated
{
	public class CoherenceSyncImpl
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void OnRuntimeMethodLoad()
		{
		}

		private static string ComponentNameFromTypeId(uint componentTypeId)
		{
			return null;
		}

		private static ICoherenceComponentData[] CreateInitialComponents(ICoherenceSync self, string uuid, bool isFromGroup, AbsoluteSimulationFrame simFrame)
		{
			return null;
		}

		private static bool ReceiveInternalCommand(CoherenceBridge.EventsToken events, IEntityCommand command, Coherence.Log.Logger logger)
		{
			return false;
		}

		private static ICoherenceComponentData CreateConnectedEntityUpdateInternal(Entity parentID, Vector3 newPos, Quaternion newRot, Vector3 newScale, AbsoluteSimulationFrame simFrame)
		{
			return null;
		}

		private static uint GetConnectedEntityComponentIdInternal()
		{
			return 0u;
		}

		private static void UpdateTag(IClient client, Entity liveQuery, string tag, AbsoluteSimulationFrame simFrame)
		{
		}

		private static void RemoveTag(IClient client, Entity liveQuery)
		{
		}
	}
}
