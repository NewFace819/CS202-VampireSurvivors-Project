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
	public class CoherenceSync_796c87bb05a35b5439f21c1c826dda76 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_08882e2a54d44f33824cb13b394c002f_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_a8a18e5705b245d883b3ae3c9d7f354c_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_9b8a70ffaebb4d8895a4d5f45988b7ff_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_6772d34714774f0d9de2bc498795438c_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_5ca504fa7eb04c4dbdae157aa059a9a9_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_7e8f8f3ec4874d77846e521dd11b665f_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_1b1c6a9503344a0582dc079e0b0c2f3e_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_cdd6aa5039154adeb0dfde1715866d43_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_1c322441777d4b7ea52ed2bc924d4459_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_76acb05d5dd74f879173594e21a8740a_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_fc24bb37a556440086bccb6456d23c35_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_54e8ea4e8e03496688e1f8d274c61b12_CommandTarget;

		private CharacterController _796c87bb05a35b5439f21c1c826dda76_b494c8b235f64b08b778e6a778602d7a_CommandTarget;

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

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_08882e2a54d44f33824cb13b394c002f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_08882e2a54d44f33824cb13b394c002f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_08882e2a54d44f33824cb13b394c002f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_08882e2a54d44f33824cb13b394c002f(_796c87bb05a35b5439f21c1c826dda76_08882e2a54d44f33824cb13b394c002f command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_a8a18e5705b245d883b3ae3c9d7f354c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_a8a18e5705b245d883b3ae3c9d7f354c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_a8a18e5705b245d883b3ae3c9d7f354c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_a8a18e5705b245d883b3ae3c9d7f354c(_796c87bb05a35b5439f21c1c826dda76_a8a18e5705b245d883b3ae3c9d7f354c command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_9b8a70ffaebb4d8895a4d5f45988b7ff(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_9b8a70ffaebb4d8895a4d5f45988b7ff(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_9b8a70ffaebb4d8895a4d5f45988b7ff(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_9b8a70ffaebb4d8895a4d5f45988b7ff(_796c87bb05a35b5439f21c1c826dda76_9b8a70ffaebb4d8895a4d5f45988b7ff command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_6772d34714774f0d9de2bc498795438c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_6772d34714774f0d9de2bc498795438c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_6772d34714774f0d9de2bc498795438c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_6772d34714774f0d9de2bc498795438c(_796c87bb05a35b5439f21c1c826dda76_6772d34714774f0d9de2bc498795438c command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_5ca504fa7eb04c4dbdae157aa059a9a9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_5ca504fa7eb04c4dbdae157aa059a9a9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_5ca504fa7eb04c4dbdae157aa059a9a9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_5ca504fa7eb04c4dbdae157aa059a9a9(_796c87bb05a35b5439f21c1c826dda76_5ca504fa7eb04c4dbdae157aa059a9a9 command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_7e8f8f3ec4874d77846e521dd11b665f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_7e8f8f3ec4874d77846e521dd11b665f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_7e8f8f3ec4874d77846e521dd11b665f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_7e8f8f3ec4874d77846e521dd11b665f(_796c87bb05a35b5439f21c1c826dda76_7e8f8f3ec4874d77846e521dd11b665f command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_1b1c6a9503344a0582dc079e0b0c2f3e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_1b1c6a9503344a0582dc079e0b0c2f3e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_1b1c6a9503344a0582dc079e0b0c2f3e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_1b1c6a9503344a0582dc079e0b0c2f3e(_796c87bb05a35b5439f21c1c826dda76_1b1c6a9503344a0582dc079e0b0c2f3e command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_cdd6aa5039154adeb0dfde1715866d43(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_cdd6aa5039154adeb0dfde1715866d43(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_cdd6aa5039154adeb0dfde1715866d43(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_cdd6aa5039154adeb0dfde1715866d43(_796c87bb05a35b5439f21c1c826dda76_cdd6aa5039154adeb0dfde1715866d43 command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_1c322441777d4b7ea52ed2bc924d4459(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_1c322441777d4b7ea52ed2bc924d4459(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_1c322441777d4b7ea52ed2bc924d4459(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_1c322441777d4b7ea52ed2bc924d4459(_796c87bb05a35b5439f21c1c826dda76_1c322441777d4b7ea52ed2bc924d4459 command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_76acb05d5dd74f879173594e21a8740a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_76acb05d5dd74f879173594e21a8740a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_76acb05d5dd74f879173594e21a8740a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_76acb05d5dd74f879173594e21a8740a(_796c87bb05a35b5439f21c1c826dda76_76acb05d5dd74f879173594e21a8740a command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_fc24bb37a556440086bccb6456d23c35(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_fc24bb37a556440086bccb6456d23c35(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_fc24bb37a556440086bccb6456d23c35(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_fc24bb37a556440086bccb6456d23c35(_796c87bb05a35b5439f21c1c826dda76_fc24bb37a556440086bccb6456d23c35 command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_54e8ea4e8e03496688e1f8d274c61b12(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_54e8ea4e8e03496688e1f8d274c61b12(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_54e8ea4e8e03496688e1f8d274c61b12(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_54e8ea4e8e03496688e1f8d274c61b12(_796c87bb05a35b5439f21c1c826dda76_54e8ea4e8e03496688e1f8d274c61b12 command)
		{
		}

		private void BakeCommandBinding__796c87bb05a35b5439f21c1c826dda76_b494c8b235f64b08b778e6a778602d7a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__796c87bb05a35b5439f21c1c826dda76_b494c8b235f64b08b778e6a778602d7a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__796c87bb05a35b5439f21c1c826dda76_b494c8b235f64b08b778e6a778602d7a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__796c87bb05a35b5439f21c1c826dda76_b494c8b235f64b08b778e6a778602d7a(_796c87bb05a35b5439f21c1c826dda76_b494c8b235f64b08b778e6a778602d7a command)
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
