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
	public class CoherenceSync_5340522cd6906e04ea8628dd537141e4 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _5340522cd6906e04ea8628dd537141e4_6f959951a9e44c8ca288b746346e3239_CommandTarget;

		private Enemy_TP_GateBoss _5340522cd6906e04ea8628dd537141e4_ee310190a4fe49e5ba54a69bbb4f4f02_CommandTarget;

		private Enemy_TP_GateBoss _5340522cd6906e04ea8628dd537141e4_9fe690e45ab0438ca82eb0917252893a_CommandTarget;

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

		private void BakeCommandBinding__5340522cd6906e04ea8628dd537141e4_6f959951a9e44c8ca288b746346e3239(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5340522cd6906e04ea8628dd537141e4_6f959951a9e44c8ca288b746346e3239(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5340522cd6906e04ea8628dd537141e4_6f959951a9e44c8ca288b746346e3239(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5340522cd6906e04ea8628dd537141e4_6f959951a9e44c8ca288b746346e3239(_5340522cd6906e04ea8628dd537141e4_6f959951a9e44c8ca288b746346e3239 command)
		{
		}

		private void BakeCommandBinding__5340522cd6906e04ea8628dd537141e4_ee310190a4fe49e5ba54a69bbb4f4f02(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5340522cd6906e04ea8628dd537141e4_ee310190a4fe49e5ba54a69bbb4f4f02(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5340522cd6906e04ea8628dd537141e4_ee310190a4fe49e5ba54a69bbb4f4f02(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5340522cd6906e04ea8628dd537141e4_ee310190a4fe49e5ba54a69bbb4f4f02(_5340522cd6906e04ea8628dd537141e4_ee310190a4fe49e5ba54a69bbb4f4f02 command)
		{
		}

		private void BakeCommandBinding__5340522cd6906e04ea8628dd537141e4_9fe690e45ab0438ca82eb0917252893a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5340522cd6906e04ea8628dd537141e4_9fe690e45ab0438ca82eb0917252893a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5340522cd6906e04ea8628dd537141e4_9fe690e45ab0438ca82eb0917252893a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5340522cd6906e04ea8628dd537141e4_9fe690e45ab0438ca82eb0917252893a(_5340522cd6906e04ea8628dd537141e4_9fe690e45ab0438ca82eb0917252893a command)
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
