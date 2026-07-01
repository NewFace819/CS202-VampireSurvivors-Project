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
	public class CoherenceSync_659457ea8383c26479da42104695f1a8 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _659457ea8383c26479da42104695f1a8_8c9a4f5db0cb41d18d364956937bb7de_CommandTarget;

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

		private void BakeCommandBinding__659457ea8383c26479da42104695f1a8_8c9a4f5db0cb41d18d364956937bb7de(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__659457ea8383c26479da42104695f1a8_8c9a4f5db0cb41d18d364956937bb7de(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__659457ea8383c26479da42104695f1a8_8c9a4f5db0cb41d18d364956937bb7de(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__659457ea8383c26479da42104695f1a8_8c9a4f5db0cb41d18d364956937bb7de(_659457ea8383c26479da42104695f1a8_8c9a4f5db0cb41d18d364956937bb7de command)
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
