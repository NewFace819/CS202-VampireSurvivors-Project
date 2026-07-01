using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;
using VampireSurvivors.Objects.Stages;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_a1843490b1f51f841aeba7d96dc46777 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private PlatformZoneMovement _a1843490b1f51f841aeba7d96dc46777_879582440d624b1d9dc4b6de7cb698e3_CommandTarget;

		private DraculaCutscene _a1843490b1f51f841aeba7d96dc46777_9215320efed74935b9d66ad80e8e56e6_CommandTarget;

		private DraculaCutscene _a1843490b1f51f841aeba7d96dc46777_dd3e7ae5f79349b0b29a3140435fe135_CommandTarget;

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

		private void BakeCommandBinding__a1843490b1f51f841aeba7d96dc46777_879582440d624b1d9dc4b6de7cb698e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a1843490b1f51f841aeba7d96dc46777_879582440d624b1d9dc4b6de7cb698e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a1843490b1f51f841aeba7d96dc46777_879582440d624b1d9dc4b6de7cb698e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a1843490b1f51f841aeba7d96dc46777_879582440d624b1d9dc4b6de7cb698e3(_a1843490b1f51f841aeba7d96dc46777_879582440d624b1d9dc4b6de7cb698e3 command)
		{
		}

		private void BakeCommandBinding__a1843490b1f51f841aeba7d96dc46777_9215320efed74935b9d66ad80e8e56e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a1843490b1f51f841aeba7d96dc46777_9215320efed74935b9d66ad80e8e56e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a1843490b1f51f841aeba7d96dc46777_9215320efed74935b9d66ad80e8e56e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a1843490b1f51f841aeba7d96dc46777_9215320efed74935b9d66ad80e8e56e6(_a1843490b1f51f841aeba7d96dc46777_9215320efed74935b9d66ad80e8e56e6 command)
		{
		}

		private void BakeCommandBinding__a1843490b1f51f841aeba7d96dc46777_dd3e7ae5f79349b0b29a3140435fe135(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a1843490b1f51f841aeba7d96dc46777_dd3e7ae5f79349b0b29a3140435fe135(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a1843490b1f51f841aeba7d96dc46777_dd3e7ae5f79349b0b29a3140435fe135(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a1843490b1f51f841aeba7d96dc46777_dd3e7ae5f79349b0b29a3140435fe135(_a1843490b1f51f841aeba7d96dc46777_dd3e7ae5f79349b0b29a3140435fe135 command)
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
