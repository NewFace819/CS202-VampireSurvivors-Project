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
using VampireSurvivors.Objects.Characters.Enemies;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_00c0cbb90f61cdc43be6d6c474d3375c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _00c0cbb90f61cdc43be6d6c474d3375c_721c2d9535c7459a9436b4e385a7fa7e_CommandTarget;

		private Enemy_TP_GateBoss _00c0cbb90f61cdc43be6d6c474d3375c_11960840f2ef420ba0aa340902ab2f56_CommandTarget;

		private Enemy_TP_GateBoss _00c0cbb90f61cdc43be6d6c474d3375c_8b464d6515a34af8a04a87bb4d2ba2ae_CommandTarget;

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

		private void BakeCommandBinding__00c0cbb90f61cdc43be6d6c474d3375c_721c2d9535c7459a9436b4e385a7fa7e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__00c0cbb90f61cdc43be6d6c474d3375c_721c2d9535c7459a9436b4e385a7fa7e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__00c0cbb90f61cdc43be6d6c474d3375c_721c2d9535c7459a9436b4e385a7fa7e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__00c0cbb90f61cdc43be6d6c474d3375c_721c2d9535c7459a9436b4e385a7fa7e(_00c0cbb90f61cdc43be6d6c474d3375c_721c2d9535c7459a9436b4e385a7fa7e command)
		{
		}

		private void BakeCommandBinding__00c0cbb90f61cdc43be6d6c474d3375c_11960840f2ef420ba0aa340902ab2f56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__00c0cbb90f61cdc43be6d6c474d3375c_11960840f2ef420ba0aa340902ab2f56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__00c0cbb90f61cdc43be6d6c474d3375c_11960840f2ef420ba0aa340902ab2f56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__00c0cbb90f61cdc43be6d6c474d3375c_11960840f2ef420ba0aa340902ab2f56(_00c0cbb90f61cdc43be6d6c474d3375c_11960840f2ef420ba0aa340902ab2f56 command)
		{
		}

		private void BakeCommandBinding__00c0cbb90f61cdc43be6d6c474d3375c_8b464d6515a34af8a04a87bb4d2ba2ae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__00c0cbb90f61cdc43be6d6c474d3375c_8b464d6515a34af8a04a87bb4d2ba2ae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__00c0cbb90f61cdc43be6d6c474d3375c_8b464d6515a34af8a04a87bb4d2ba2ae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__00c0cbb90f61cdc43be6d6c474d3375c_8b464d6515a34af8a04a87bb4d2ba2ae(_00c0cbb90f61cdc43be6d6c474d3375c_8b464d6515a34af8a04a87bb4d2ba2ae command)
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
