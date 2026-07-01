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
	public class CoherenceSync_ebdfcd7e1825197479d08dccba6da734 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _ebdfcd7e1825197479d08dccba6da734_f5c0231d9a1e49b8b932144bf1d63deb_CommandTarget;

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

		private void BakeCommandBinding__ebdfcd7e1825197479d08dccba6da734_f5c0231d9a1e49b8b932144bf1d63deb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ebdfcd7e1825197479d08dccba6da734_f5c0231d9a1e49b8b932144bf1d63deb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ebdfcd7e1825197479d08dccba6da734_f5c0231d9a1e49b8b932144bf1d63deb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ebdfcd7e1825197479d08dccba6da734_f5c0231d9a1e49b8b932144bf1d63deb(_ebdfcd7e1825197479d08dccba6da734_f5c0231d9a1e49b8b932144bf1d63deb command)
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
