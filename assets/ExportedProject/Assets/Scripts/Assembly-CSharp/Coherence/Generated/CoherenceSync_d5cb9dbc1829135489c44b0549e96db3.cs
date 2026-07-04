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
	public class CoherenceSync_d5cb9dbc1829135489c44b0549e96db3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _d5cb9dbc1829135489c44b0549e96db3_bf482398af414883acbeb859eac4f5c9_CommandTarget;

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

		private void BakeCommandBinding__d5cb9dbc1829135489c44b0549e96db3_bf482398af414883acbeb859eac4f5c9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d5cb9dbc1829135489c44b0549e96db3_bf482398af414883acbeb859eac4f5c9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d5cb9dbc1829135489c44b0549e96db3_bf482398af414883acbeb859eac4f5c9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d5cb9dbc1829135489c44b0549e96db3_bf482398af414883acbeb859eac4f5c9(_d5cb9dbc1829135489c44b0549e96db3_bf482398af414883acbeb859eac4f5c9 command)
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
