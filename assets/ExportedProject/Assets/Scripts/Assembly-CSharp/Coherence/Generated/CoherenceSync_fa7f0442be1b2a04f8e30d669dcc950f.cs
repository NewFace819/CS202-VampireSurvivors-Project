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
	public class CoherenceSync_fa7f0442be1b2a04f8e30d669dcc950f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _fa7f0442be1b2a04f8e30d669dcc950f_bbfaef1078ae4e65bf8b5f39b111a27c_CommandTarget;

		private EX_Boss_Colossus _fa7f0442be1b2a04f8e30d669dcc950f_01e652c1fce34f769278c9baf610141a_CommandTarget;

		private EX_Boss_Colossus _fa7f0442be1b2a04f8e30d669dcc950f_4cd2e1bc70734129bc80def20c05d1e9_CommandTarget;

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

		private void BakeCommandBinding__fa7f0442be1b2a04f8e30d669dcc950f_bbfaef1078ae4e65bf8b5f39b111a27c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fa7f0442be1b2a04f8e30d669dcc950f_bbfaef1078ae4e65bf8b5f39b111a27c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fa7f0442be1b2a04f8e30d669dcc950f_bbfaef1078ae4e65bf8b5f39b111a27c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fa7f0442be1b2a04f8e30d669dcc950f_bbfaef1078ae4e65bf8b5f39b111a27c(_fa7f0442be1b2a04f8e30d669dcc950f_bbfaef1078ae4e65bf8b5f39b111a27c command)
		{
		}

		private void BakeCommandBinding__fa7f0442be1b2a04f8e30d669dcc950f_01e652c1fce34f769278c9baf610141a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fa7f0442be1b2a04f8e30d669dcc950f_01e652c1fce34f769278c9baf610141a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fa7f0442be1b2a04f8e30d669dcc950f_01e652c1fce34f769278c9baf610141a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fa7f0442be1b2a04f8e30d669dcc950f_01e652c1fce34f769278c9baf610141a(_fa7f0442be1b2a04f8e30d669dcc950f_01e652c1fce34f769278c9baf610141a command)
		{
		}

		private void BakeCommandBinding__fa7f0442be1b2a04f8e30d669dcc950f_4cd2e1bc70734129bc80def20c05d1e9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fa7f0442be1b2a04f8e30d669dcc950f_4cd2e1bc70734129bc80def20c05d1e9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fa7f0442be1b2a04f8e30d669dcc950f_4cd2e1bc70734129bc80def20c05d1e9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fa7f0442be1b2a04f8e30d669dcc950f_4cd2e1bc70734129bc80def20c05d1e9(_fa7f0442be1b2a04f8e30d669dcc950f_4cd2e1bc70734129bc80def20c05d1e9 command)
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
