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
	public class CoherenceSync_2ac70e36146e3d04582a2f11047c9b73 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _2ac70e36146e3d04582a2f11047c9b73_6435f71f7257420f86a45e32986f6cad_CommandTarget;

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

		private void BakeCommandBinding__2ac70e36146e3d04582a2f11047c9b73_6435f71f7257420f86a45e32986f6cad(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ac70e36146e3d04582a2f11047c9b73_6435f71f7257420f86a45e32986f6cad(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ac70e36146e3d04582a2f11047c9b73_6435f71f7257420f86a45e32986f6cad(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ac70e36146e3d04582a2f11047c9b73_6435f71f7257420f86a45e32986f6cad(_2ac70e36146e3d04582a2f11047c9b73_6435f71f7257420f86a45e32986f6cad command)
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
