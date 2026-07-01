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
	public class CoherenceSync_a2bda7ab6fb525d41b33b10e085ca5e3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_09381bea4d024e118dc3e8d06c1295f9_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_2ac98b1802b64cc3ab5f7eb89b2fbf45_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_479acd228da84588922c6e08e806fc18_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_a311c2d0e0ff4b938e5aae4e33b6c6e3_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_b93053dcf8bd4f8fa55ed3e35703d191_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_ae9dc77c37c842059f4b4b17d420ec1d_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_8c6c2852e94f4d5a847d665bf0674b5d_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_ab139b0c850a458ebb68bf001c3112ce_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_e5d74034ebf647258cb842d270611efb_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_4dcdef24f6f14e3aaaf811ff1add404b_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_0502c98f72094341bbab6c6ad9b8944f_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_3c63f6eb71694197ad81e3e138bbb74c_CommandTarget;

		private CharacterController _a2bda7ab6fb525d41b33b10e085ca5e3_690daecaa1284796bcc853ad7c6659b6_CommandTarget;

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

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_09381bea4d024e118dc3e8d06c1295f9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_09381bea4d024e118dc3e8d06c1295f9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_09381bea4d024e118dc3e8d06c1295f9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_09381bea4d024e118dc3e8d06c1295f9(_a2bda7ab6fb525d41b33b10e085ca5e3_09381bea4d024e118dc3e8d06c1295f9 command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_2ac98b1802b64cc3ab5f7eb89b2fbf45(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_2ac98b1802b64cc3ab5f7eb89b2fbf45(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_2ac98b1802b64cc3ab5f7eb89b2fbf45(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_2ac98b1802b64cc3ab5f7eb89b2fbf45(_a2bda7ab6fb525d41b33b10e085ca5e3_2ac98b1802b64cc3ab5f7eb89b2fbf45 command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_479acd228da84588922c6e08e806fc18(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_479acd228da84588922c6e08e806fc18(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_479acd228da84588922c6e08e806fc18(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_479acd228da84588922c6e08e806fc18(_a2bda7ab6fb525d41b33b10e085ca5e3_479acd228da84588922c6e08e806fc18 command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_a311c2d0e0ff4b938e5aae4e33b6c6e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_a311c2d0e0ff4b938e5aae4e33b6c6e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_a311c2d0e0ff4b938e5aae4e33b6c6e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_a311c2d0e0ff4b938e5aae4e33b6c6e3(_a2bda7ab6fb525d41b33b10e085ca5e3_a311c2d0e0ff4b938e5aae4e33b6c6e3 command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_b93053dcf8bd4f8fa55ed3e35703d191(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_b93053dcf8bd4f8fa55ed3e35703d191(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_b93053dcf8bd4f8fa55ed3e35703d191(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_b93053dcf8bd4f8fa55ed3e35703d191(_a2bda7ab6fb525d41b33b10e085ca5e3_b93053dcf8bd4f8fa55ed3e35703d191 command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_ae9dc77c37c842059f4b4b17d420ec1d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_ae9dc77c37c842059f4b4b17d420ec1d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_ae9dc77c37c842059f4b4b17d420ec1d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_ae9dc77c37c842059f4b4b17d420ec1d(_a2bda7ab6fb525d41b33b10e085ca5e3_ae9dc77c37c842059f4b4b17d420ec1d command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_8c6c2852e94f4d5a847d665bf0674b5d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_8c6c2852e94f4d5a847d665bf0674b5d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_8c6c2852e94f4d5a847d665bf0674b5d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_8c6c2852e94f4d5a847d665bf0674b5d(_a2bda7ab6fb525d41b33b10e085ca5e3_8c6c2852e94f4d5a847d665bf0674b5d command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_ab139b0c850a458ebb68bf001c3112ce(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_ab139b0c850a458ebb68bf001c3112ce(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_ab139b0c850a458ebb68bf001c3112ce(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_ab139b0c850a458ebb68bf001c3112ce(_a2bda7ab6fb525d41b33b10e085ca5e3_ab139b0c850a458ebb68bf001c3112ce command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_e5d74034ebf647258cb842d270611efb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_e5d74034ebf647258cb842d270611efb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_e5d74034ebf647258cb842d270611efb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_e5d74034ebf647258cb842d270611efb(_a2bda7ab6fb525d41b33b10e085ca5e3_e5d74034ebf647258cb842d270611efb command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_4dcdef24f6f14e3aaaf811ff1add404b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_4dcdef24f6f14e3aaaf811ff1add404b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_4dcdef24f6f14e3aaaf811ff1add404b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_4dcdef24f6f14e3aaaf811ff1add404b(_a2bda7ab6fb525d41b33b10e085ca5e3_4dcdef24f6f14e3aaaf811ff1add404b command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_0502c98f72094341bbab6c6ad9b8944f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_0502c98f72094341bbab6c6ad9b8944f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_0502c98f72094341bbab6c6ad9b8944f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_0502c98f72094341bbab6c6ad9b8944f(_a2bda7ab6fb525d41b33b10e085ca5e3_0502c98f72094341bbab6c6ad9b8944f command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_3c63f6eb71694197ad81e3e138bbb74c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_3c63f6eb71694197ad81e3e138bbb74c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_3c63f6eb71694197ad81e3e138bbb74c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_3c63f6eb71694197ad81e3e138bbb74c(_a2bda7ab6fb525d41b33b10e085ca5e3_3c63f6eb71694197ad81e3e138bbb74c command)
		{
		}

		private void BakeCommandBinding__a2bda7ab6fb525d41b33b10e085ca5e3_690daecaa1284796bcc853ad7c6659b6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2bda7ab6fb525d41b33b10e085ca5e3_690daecaa1284796bcc853ad7c6659b6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2bda7ab6fb525d41b33b10e085ca5e3_690daecaa1284796bcc853ad7c6659b6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2bda7ab6fb525d41b33b10e085ca5e3_690daecaa1284796bcc853ad7c6659b6(_a2bda7ab6fb525d41b33b10e085ca5e3_690daecaa1284796bcc853ad7c6659b6 command)
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
