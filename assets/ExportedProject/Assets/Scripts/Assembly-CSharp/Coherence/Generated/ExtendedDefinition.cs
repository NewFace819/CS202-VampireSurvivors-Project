using Coherence.Connection;
using Coherence.Entities;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using UnityEngine;

namespace Coherence.Generated
{
	public class ExtendedDefinition : Definition, IExtendedDefinition, IDefinition, ISchemaSpecificComponentDeserialize, ISchemaSpecificComponentSerialize, IAuthorityManagement, IBuiltInComponentAccess, IComponentInfo
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void OnRuntimeMethodLoad()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void OverrideRSL()
		{
		}

		public string SchemaHash()
		{
			return null;
		}

		public ICoherenceComponentData CreateArchetypeComponent(uint index)
		{
			return null;
		}

		public ICoherenceComponentData CreateConnectedEntityComponent(Entity parent, Vector3 relativePos, Quaternion relativeRot, Vector3 relativeScale)
		{
			return null;
		}

		public ICoherenceComponentData CreateConnectionComponent(ClientID clientID, ConnectionType connectionType)
		{
			return null;
		}

		public ICoherenceComponentData CreateConnectionSceneComponent(uint scene)
		{
			return null;
		}

		public ICoherenceComponentData CreateGlobalQueryComponent()
		{
			return null;
		}

		public ICoherenceComponentData CreatePersistenceComponent()
		{
			return null;
		}

		public ICoherenceComponentData CreatePreserveChildrenComponent()
		{
			return null;
		}

		public ICoherenceComponentData CreateSceneComponent(uint scene)
		{
			return null;
		}

		public ICoherenceComponentData CreateTagComponent(string tag)
		{
			return null;
		}

		public ICoherenceComponentData CreateTagQueryComponent(string tag)
		{
			return null;
		}

		public ICoherenceComponentData CreateUUIDComponent(string UUID)
		{
			return null;
		}

		public ICoherenceComponentData CreateWorldPositionComponent(Vector3 pos, AbsoluteSimulationFrame simFrame)
		{
			return null;
		}

		public ICoherenceComponentData CreateWorldRotationComponent(Quaternion rot, AbsoluteSimulationFrame simFrame)
		{
			return null;
		}

		public ICoherenceComponentData CreateWorldPositionQueryComponent(Vector3 center, float radius)
		{
			return null;
		}

		public bool IsAdoptOrphanCommand(uint compType)
		{
			return false;
		}

		public bool IsAuthorityRequestCommand(uint compType)
		{
			return false;
		}

		public bool IsAuthorityTransferCommand(uint compType)
		{
			return false;
		}

		public bool IsPersistenceReadyCommand(uint compType)
		{
			return false;
		}

		public bool CanRouteCommand(uint compType, MessageTarget target)
		{
			return false;
		}

		public bool IsConnectedEntityComponent(uint compType)
		{
			return false;
		}

		public bool IsConnectionComponent(uint compType)
		{
			return false;
		}

		public bool IsGlobalComponent(uint compType)
		{
			return false;
		}

		public bool IsGlobalQueryComponent(uint compType)
		{
			return false;
		}

		public bool IsPersistenceComponent(uint compType)
		{
			return false;
		}

		public bool IsSceneComponent(uint compType)
		{
			return false;
		}

		public bool IsTagComponent(uint compType)
		{
			return false;
		}

		public bool IsTagQueryComponent(uint compType)
		{
			return false;
		}

		public bool IsUUIDComponent(uint compType)
		{
			return false;
		}

		public bool IsWorldPositionComponent(uint compType)
		{
			return false;
		}

		public bool IsWorldPositionQueryComponent(uint compType)
		{
			return false;
		}

		public IEntityCommand CreateQuerySyncedCommand(Entity entity, bool liveQuerySynced, bool globalQuerySynced)
		{
			return null;
		}

		public AuthorityType GetAuthorityTypeFromAuthorityRequestCommand(IEntityCommand command)
		{
			return default(AuthorityType);
		}

		public AuthorityType GetAuthorityTypeFromAuthorityTransferCommand(IEntityCommand command)
		{
			return default(AuthorityType);
		}

		public ClientID GetAuthorityRequesterFromCommand(IEntityCommand command)
		{
			return default(ClientID);
		}

		public ClientID GetNewAuthorityFromAuthorityTransferCommmand(IEntityCommand command)
		{
			return default(ClientID);
		}

		public bool GetIsAcceptedFromAuthorityTransferCommand(IEntityCommand command)
		{
			return false;
		}

		public ICoherenceComponentData GetArchetypeComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public int GetArchetypeIndexFromComponent(ICoherenceComponentData comp)
		{
			return 0;
		}

		public ICoherenceComponentData GetConnectedEntityComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public Entity GetConnectedEntityFromConnectedEntityComponent(ICoherenceComponentData comp)
		{
			return default(Entity);
		}

		public Vector3 GetRelativePosFromConnectedEntityComponent(ICoherenceComponentData comp)
		{
			return default(Vector3);
		}

		public Quaternion GetRelativeRotFromConnectedEntityComponent(ICoherenceComponentData comp)
		{
			return default(Quaternion);
		}

		public ICoherenceComponentData GetConnectionComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public ICoherenceComponentData GetConnectionSceneComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public uint GetConnectionSceneFromComponent(ICoherenceComponentData comp)
		{
			return 0u;
		}

		public ICoherenceComponentData GetGlobalComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public ICoherenceComponentData GetGlobalQueryComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public ICoherenceComponentData GetPersistenceComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public ICoherenceComponentData GetPreserveChildrenComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public ICoherenceComponentData GetSceneComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public uint GetSceneFromComponent(ICoherenceComponentData comp)
		{
			return 0u;
		}

		public ICoherenceComponentData GetTagComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public ICoherenceComponentData GetTagQueryComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public string GetTagFromTagComponent(ICoherenceComponentData comp)
		{
			return null;
		}

		public string GetTagFromTagQueryComponent(ICoherenceComponentData comp)
		{
			return null;
		}

		public ICoherenceComponentData GetUUIDComponent(ICoherenceComponentData[] comps)
		{
			return null;
		}

		public string GetUUIDFromComponent(ICoherenceComponentData comp)
		{
			return null;
		}

		public (ICoherenceComponentData, int) GetWorldPositionComponent(ICoherenceComponentData[] comps)
		{
			return default((ICoherenceComponentData, int));
		}

		public Vector3 GetWorldPositionFromComponent(ICoherenceComponentData comp)
		{
			return default(Vector3);
		}

		public void SetWorldPosition(ref ICoherenceComponentData comp, Vector3 newPosition)
		{
		}

		public (ICoherenceComponentData, int) GetWorldRotationComponent(ICoherenceComponentData[] comps)
		{
			return default((ICoherenceComponentData, int));
		}

		public Quaternion GetWorldRotationFromComponent(ICoherenceComponentData comp)
		{
			return default(Quaternion);
		}

		public void SetWorldRotation(ref ICoherenceComponentData comp, Quaternion newRotation)
		{
		}

		public (ICoherenceComponentData, int) GetWorldPositionQueryComponent(ICoherenceComponentData[] comps)
		{
			return default((ICoherenceComponentData, int));
		}

		public Vector3 GetWorldPositionQueryCenterFromComponent(ICoherenceComponentData comp)
		{
			return default(Vector3);
		}

		public float GetWorldPositionQueryRadiusFromComponent(ICoherenceComponentData comp)
		{
			return 0f;
		}

		public void SetWorldPositionQueryCenter(ref ICoherenceComponentData comp, Vector3 newCenter)
		{
		}

		public void RemoveComponentsInvalidatedByConnectedEntity(ref ICoherenceComponentData[] comps)
		{
		}

		public bool HasValidConnectedEntityID(ICoherenceComponentData comp)
		{
			return false;
		}

		public bool HasValidConnectionScene(ICoherenceComponentData comp)
		{
			return false;
		}

		public bool HasValidWorldPositionQueryCenter(ICoherenceComponentData comp)
		{
			return false;
		}

		public bool HasValidWorldPositionQueryRadius(ICoherenceComponentData comp)
		{
			return false;
		}

		public bool HasValidWorldPositionPosition(ICoherenceComponentData comp)
		{
			return false;
		}

		public bool HasValidUniqueIDUUID(ICoherenceComponentData comp)
		{
			return false;
		}

		public bool HasValidArchetypeIndex(ICoherenceComponentData comp)
		{
			return false;
		}

		public bool HasValidTagQueryTag(ICoherenceComponentData comp)
		{
			return false;
		}

		public bool HasValidTagTag(ICoherenceComponentData comp)
		{
			return false;
		}

		public uint GetArchetypeIndexByName(string name)
		{
			return 0u;
		}

		public bool GetEntityArchetype(uint index, out EntityArchetype archetype)
		{
			archetype = default(EntityArchetype);
			return false;
		}
	}
}
