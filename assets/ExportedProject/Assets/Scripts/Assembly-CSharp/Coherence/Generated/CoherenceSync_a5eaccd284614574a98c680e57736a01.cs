using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Characters;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_a5eaccd284614574a98c680e57736a01 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _a5eaccd284614574a98c680e57736a01_fcb2f30822fd4fd5a582b5c38801ca95_CommandTarget;

		private IClient client;

		private CoherenceBridge bridge;

		private readonly Dictionary<string, Binding> bakedValueBindings;

		private Dictionary<string, Action<CommandBinding, CommandsHandler>> bakedCommandBindings;

		public override Binding BakeValueBinding(Binding valueBinding)
		{
			return null;
		}

		public override void BakeCommandBinding(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void BakeCommandBinding__a5eaccd284614574a98c680e57736a01_fcb2f30822fd4fd5a582b5c38801ca95(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5eaccd284614574a98c680e57736a01_fcb2f30822fd4fd5a582b5c38801ca95(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5eaccd284614574a98c680e57736a01_fcb2f30822fd4fd5a582b5c38801ca95(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5eaccd284614574a98c680e57736a01_fcb2f30822fd4fd5a582b5c38801ca95(_a5eaccd284614574a98c680e57736a01_fcb2f30822fd4fd5a582b5c38801ca95 command)
		{
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
		}

		public override void CreateEntity(bool usesLodsAtRuntime, string archetypeName, AbsoluteSimulationFrame simFrame, List<ICoherenceComponentData> components)
		{
		}

		public override void Dispose()
		{
		}

		public override void Initialize(Entity entityId, CoherenceBridge bridge, IClient client, CoherenceInput input, Logger logger)
		{
		}
	}
}
