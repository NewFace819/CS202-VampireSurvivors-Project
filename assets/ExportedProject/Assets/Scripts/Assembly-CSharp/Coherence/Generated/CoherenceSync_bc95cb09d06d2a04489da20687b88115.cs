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
	public class CoherenceSync_bc95cb09d06d2a04489da20687b88115 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _bc95cb09d06d2a04489da20687b88115_aa7e021e5bb9446f8e2ebf8fed99053a_CommandTarget;

		private EnemyJeneviv _bc95cb09d06d2a04489da20687b88115_93c3f29f2fdf44d49aa8807a5189250b_CommandTarget;

		private EnemyJeneviv _bc95cb09d06d2a04489da20687b88115_d63c617ce3aa41a1a5ec6bdae9b6ee6c_CommandTarget;

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

		private void BakeCommandBinding__bc95cb09d06d2a04489da20687b88115_aa7e021e5bb9446f8e2ebf8fed99053a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bc95cb09d06d2a04489da20687b88115_aa7e021e5bb9446f8e2ebf8fed99053a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bc95cb09d06d2a04489da20687b88115_aa7e021e5bb9446f8e2ebf8fed99053a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bc95cb09d06d2a04489da20687b88115_aa7e021e5bb9446f8e2ebf8fed99053a(_bc95cb09d06d2a04489da20687b88115_aa7e021e5bb9446f8e2ebf8fed99053a command)
		{
		}

		private void BakeCommandBinding__bc95cb09d06d2a04489da20687b88115_93c3f29f2fdf44d49aa8807a5189250b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bc95cb09d06d2a04489da20687b88115_93c3f29f2fdf44d49aa8807a5189250b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bc95cb09d06d2a04489da20687b88115_93c3f29f2fdf44d49aa8807a5189250b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bc95cb09d06d2a04489da20687b88115_93c3f29f2fdf44d49aa8807a5189250b(_bc95cb09d06d2a04489da20687b88115_93c3f29f2fdf44d49aa8807a5189250b command)
		{
		}

		private void BakeCommandBinding__bc95cb09d06d2a04489da20687b88115_d63c617ce3aa41a1a5ec6bdae9b6ee6c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bc95cb09d06d2a04489da20687b88115_d63c617ce3aa41a1a5ec6bdae9b6ee6c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bc95cb09d06d2a04489da20687b88115_d63c617ce3aa41a1a5ec6bdae9b6ee6c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bc95cb09d06d2a04489da20687b88115_d63c617ce3aa41a1a5ec6bdae9b6ee6c(_bc95cb09d06d2a04489da20687b88115_d63c617ce3aa41a1a5ec6bdae9b6ee6c command)
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
