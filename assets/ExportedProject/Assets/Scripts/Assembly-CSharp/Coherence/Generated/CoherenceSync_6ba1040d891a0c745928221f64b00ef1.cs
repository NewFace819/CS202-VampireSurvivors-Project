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
	public class CoherenceSync_6ba1040d891a0c745928221f64b00ef1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _6ba1040d891a0c745928221f64b00ef1_79f57a7c145442bfaccb6408051a0907_CommandTarget;

		private Enemy_TP_GateBoss _6ba1040d891a0c745928221f64b00ef1_e78497d121b34e23b8f521f92708768f_CommandTarget;

		private Enemy_TP_GateBoss _6ba1040d891a0c745928221f64b00ef1_64c9d05631bd438c8d3ddcb162a66189_CommandTarget;

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

		private void BakeCommandBinding__6ba1040d891a0c745928221f64b00ef1_79f57a7c145442bfaccb6408051a0907(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ba1040d891a0c745928221f64b00ef1_79f57a7c145442bfaccb6408051a0907(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ba1040d891a0c745928221f64b00ef1_79f57a7c145442bfaccb6408051a0907(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ba1040d891a0c745928221f64b00ef1_79f57a7c145442bfaccb6408051a0907(_6ba1040d891a0c745928221f64b00ef1_79f57a7c145442bfaccb6408051a0907 command)
		{
		}

		private void BakeCommandBinding__6ba1040d891a0c745928221f64b00ef1_e78497d121b34e23b8f521f92708768f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ba1040d891a0c745928221f64b00ef1_e78497d121b34e23b8f521f92708768f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ba1040d891a0c745928221f64b00ef1_e78497d121b34e23b8f521f92708768f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ba1040d891a0c745928221f64b00ef1_e78497d121b34e23b8f521f92708768f(_6ba1040d891a0c745928221f64b00ef1_e78497d121b34e23b8f521f92708768f command)
		{
		}

		private void BakeCommandBinding__6ba1040d891a0c745928221f64b00ef1_64c9d05631bd438c8d3ddcb162a66189(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ba1040d891a0c745928221f64b00ef1_64c9d05631bd438c8d3ddcb162a66189(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ba1040d891a0c745928221f64b00ef1_64c9d05631bd438c8d3ddcb162a66189(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ba1040d891a0c745928221f64b00ef1_64c9d05631bd438c8d3ddcb162a66189(_6ba1040d891a0c745928221f64b00ef1_64c9d05631bd438c8d3ddcb162a66189 command)
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
