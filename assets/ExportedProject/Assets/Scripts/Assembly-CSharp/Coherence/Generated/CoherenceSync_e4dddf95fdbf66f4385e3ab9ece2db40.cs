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
	public class CoherenceSync_e4dddf95fdbf66f4385e3ab9ece2db40 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _e4dddf95fdbf66f4385e3ab9ece2db40_682b07ac956f42a1a55e1b5c3b3facf2_CommandTarget;

		private Enemy_TP_GateBoss _e4dddf95fdbf66f4385e3ab9ece2db40_dd88e5781a854503b78310cd013284ec_CommandTarget;

		private Enemy_TP_GateBoss _e4dddf95fdbf66f4385e3ab9ece2db40_8c2a42fae6e3462aa12f9c13ebcf5451_CommandTarget;

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

		private void BakeCommandBinding__e4dddf95fdbf66f4385e3ab9ece2db40_682b07ac956f42a1a55e1b5c3b3facf2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4dddf95fdbf66f4385e3ab9ece2db40_682b07ac956f42a1a55e1b5c3b3facf2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4dddf95fdbf66f4385e3ab9ece2db40_682b07ac956f42a1a55e1b5c3b3facf2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4dddf95fdbf66f4385e3ab9ece2db40_682b07ac956f42a1a55e1b5c3b3facf2(_e4dddf95fdbf66f4385e3ab9ece2db40_682b07ac956f42a1a55e1b5c3b3facf2 command)
		{
		}

		private void BakeCommandBinding__e4dddf95fdbf66f4385e3ab9ece2db40_dd88e5781a854503b78310cd013284ec(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4dddf95fdbf66f4385e3ab9ece2db40_dd88e5781a854503b78310cd013284ec(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4dddf95fdbf66f4385e3ab9ece2db40_dd88e5781a854503b78310cd013284ec(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4dddf95fdbf66f4385e3ab9ece2db40_dd88e5781a854503b78310cd013284ec(_e4dddf95fdbf66f4385e3ab9ece2db40_dd88e5781a854503b78310cd013284ec command)
		{
		}

		private void BakeCommandBinding__e4dddf95fdbf66f4385e3ab9ece2db40_8c2a42fae6e3462aa12f9c13ebcf5451(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4dddf95fdbf66f4385e3ab9ece2db40_8c2a42fae6e3462aa12f9c13ebcf5451(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4dddf95fdbf66f4385e3ab9ece2db40_8c2a42fae6e3462aa12f9c13ebcf5451(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4dddf95fdbf66f4385e3ab9ece2db40_8c2a42fae6e3462aa12f9c13ebcf5451(_e4dddf95fdbf66f4385e3ab9ece2db40_8c2a42fae6e3462aa12f9c13ebcf5451 command)
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
