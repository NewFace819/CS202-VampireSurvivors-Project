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
	public class CoherenceSync_7470f17d92cd12147bae732a945223ba : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _7470f17d92cd12147bae732a945223ba_afd719c0bccc48ce9d075d863b810e04_CommandTarget;

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

		private void BakeCommandBinding__7470f17d92cd12147bae732a945223ba_afd719c0bccc48ce9d075d863b810e04(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7470f17d92cd12147bae732a945223ba_afd719c0bccc48ce9d075d863b810e04(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7470f17d92cd12147bae732a945223ba_afd719c0bccc48ce9d075d863b810e04(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7470f17d92cd12147bae732a945223ba_afd719c0bccc48ce9d075d863b810e04(_7470f17d92cd12147bae732a945223ba_afd719c0bccc48ce9d075d863b810e04 command)
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
