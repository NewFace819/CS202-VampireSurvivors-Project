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
	public class CoherenceSync_58bf7607b8b0aec4597e8088feeda1e5 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _58bf7607b8b0aec4597e8088feeda1e5_62f6af8fe90a4732b1d578cc3790f37b_CommandTarget;

		private EnemyLegion _58bf7607b8b0aec4597e8088feeda1e5_384f037a810442c38207d537c0d1b96d_CommandTarget;

		private EnemyLegion _58bf7607b8b0aec4597e8088feeda1e5_7369275c0c0f4ce0b4c9b60e0f4bded4_CommandTarget;

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

		private void BakeCommandBinding__58bf7607b8b0aec4597e8088feeda1e5_62f6af8fe90a4732b1d578cc3790f37b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__58bf7607b8b0aec4597e8088feeda1e5_62f6af8fe90a4732b1d578cc3790f37b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__58bf7607b8b0aec4597e8088feeda1e5_62f6af8fe90a4732b1d578cc3790f37b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__58bf7607b8b0aec4597e8088feeda1e5_62f6af8fe90a4732b1d578cc3790f37b(_58bf7607b8b0aec4597e8088feeda1e5_62f6af8fe90a4732b1d578cc3790f37b command)
		{
		}

		private void BakeCommandBinding__58bf7607b8b0aec4597e8088feeda1e5_384f037a810442c38207d537c0d1b96d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__58bf7607b8b0aec4597e8088feeda1e5_384f037a810442c38207d537c0d1b96d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__58bf7607b8b0aec4597e8088feeda1e5_384f037a810442c38207d537c0d1b96d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__58bf7607b8b0aec4597e8088feeda1e5_384f037a810442c38207d537c0d1b96d(_58bf7607b8b0aec4597e8088feeda1e5_384f037a810442c38207d537c0d1b96d command)
		{
		}

		private void BakeCommandBinding__58bf7607b8b0aec4597e8088feeda1e5_7369275c0c0f4ce0b4c9b60e0f4bded4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__58bf7607b8b0aec4597e8088feeda1e5_7369275c0c0f4ce0b4c9b60e0f4bded4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__58bf7607b8b0aec4597e8088feeda1e5_7369275c0c0f4ce0b4c9b60e0f4bded4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__58bf7607b8b0aec4597e8088feeda1e5_7369275c0c0f4ce0b4c9b60e0f4bded4(_58bf7607b8b0aec4597e8088feeda1e5_7369275c0c0f4ce0b4c9b60e0f4bded4 command)
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
