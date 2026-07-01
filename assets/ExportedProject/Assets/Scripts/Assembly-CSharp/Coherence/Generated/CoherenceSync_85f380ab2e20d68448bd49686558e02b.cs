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
	public class CoherenceSync_85f380ab2e20d68448bd49686558e02b : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _85f380ab2e20d68448bd49686558e02b_1e4d2e8e7a2a47de8ab92d44d40ff2a8_CommandTarget;

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

		private void BakeCommandBinding__85f380ab2e20d68448bd49686558e02b_1e4d2e8e7a2a47de8ab92d44d40ff2a8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__85f380ab2e20d68448bd49686558e02b_1e4d2e8e7a2a47de8ab92d44d40ff2a8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__85f380ab2e20d68448bd49686558e02b_1e4d2e8e7a2a47de8ab92d44d40ff2a8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__85f380ab2e20d68448bd49686558e02b_1e4d2e8e7a2a47de8ab92d44d40ff2a8(_85f380ab2e20d68448bd49686558e02b_1e4d2e8e7a2a47de8ab92d44d40ff2a8 command)
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
