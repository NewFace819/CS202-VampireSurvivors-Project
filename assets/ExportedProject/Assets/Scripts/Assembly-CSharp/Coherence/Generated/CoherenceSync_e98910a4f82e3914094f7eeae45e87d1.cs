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
	public class CoherenceSync_e98910a4f82e3914094f7eeae45e87d1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _e98910a4f82e3914094f7eeae45e87d1_135239fdf4f141ab8113b9a73924c6b8_CommandTarget;

		private Enemy_TP_GateBoss _e98910a4f82e3914094f7eeae45e87d1_2dcc05a043b74ca5871de0d1d1dd23ae_CommandTarget;

		private Enemy_TP_GateBoss _e98910a4f82e3914094f7eeae45e87d1_b6beb580999f43208f8562f1fb22b554_CommandTarget;

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

		private void BakeCommandBinding__e98910a4f82e3914094f7eeae45e87d1_135239fdf4f141ab8113b9a73924c6b8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e98910a4f82e3914094f7eeae45e87d1_135239fdf4f141ab8113b9a73924c6b8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e98910a4f82e3914094f7eeae45e87d1_135239fdf4f141ab8113b9a73924c6b8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e98910a4f82e3914094f7eeae45e87d1_135239fdf4f141ab8113b9a73924c6b8(_e98910a4f82e3914094f7eeae45e87d1_135239fdf4f141ab8113b9a73924c6b8 command)
		{
		}

		private void BakeCommandBinding__e98910a4f82e3914094f7eeae45e87d1_2dcc05a043b74ca5871de0d1d1dd23ae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e98910a4f82e3914094f7eeae45e87d1_2dcc05a043b74ca5871de0d1d1dd23ae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e98910a4f82e3914094f7eeae45e87d1_2dcc05a043b74ca5871de0d1d1dd23ae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e98910a4f82e3914094f7eeae45e87d1_2dcc05a043b74ca5871de0d1d1dd23ae(_e98910a4f82e3914094f7eeae45e87d1_2dcc05a043b74ca5871de0d1d1dd23ae command)
		{
		}

		private void BakeCommandBinding__e98910a4f82e3914094f7eeae45e87d1_b6beb580999f43208f8562f1fb22b554(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e98910a4f82e3914094f7eeae45e87d1_b6beb580999f43208f8562f1fb22b554(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e98910a4f82e3914094f7eeae45e87d1_b6beb580999f43208f8562f1fb22b554(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e98910a4f82e3914094f7eeae45e87d1_b6beb580999f43208f8562f1fb22b554(_e98910a4f82e3914094f7eeae45e87d1_b6beb580999f43208f8562f1fb22b554 command)
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
