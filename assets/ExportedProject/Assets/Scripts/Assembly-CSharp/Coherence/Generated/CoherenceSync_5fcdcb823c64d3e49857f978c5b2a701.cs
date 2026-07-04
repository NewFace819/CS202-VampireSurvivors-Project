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
	public class CoherenceSync_5fcdcb823c64d3e49857f978c5b2a701 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_2d4683c2ac094ec983f1536f1b747dba_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_3b15da76251f49d799ed23c7688b501a_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_a0654355209144a68a5d4a63902f2eb5_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_cdbd62a487ca43de82f54ff2d5e85f40_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_cdb7eff9497340359204a65956e0a05b_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_bc6459964362448a862d751f3da1b2e2_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_44419c123a64435ab81d865a0b6708c6_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_d56404cdeb6f4b558489bb1b7f3ef0d5_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_b6d61d5392b34f1e892a87c675615d85_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_9a5b2b924c3448f6b053994b80636e23_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_cc43edf558844874a8970a6faf1efe5b_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_821021e9f76548178c7567bdce480fc6_CommandTarget;

		private CharacterController _5fcdcb823c64d3e49857f978c5b2a701_3c27d8c8557941819a68725fd81b83bc_CommandTarget;

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

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_2d4683c2ac094ec983f1536f1b747dba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_2d4683c2ac094ec983f1536f1b747dba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_2d4683c2ac094ec983f1536f1b747dba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_2d4683c2ac094ec983f1536f1b747dba(_5fcdcb823c64d3e49857f978c5b2a701_2d4683c2ac094ec983f1536f1b747dba command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_3b15da76251f49d799ed23c7688b501a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_3b15da76251f49d799ed23c7688b501a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_3b15da76251f49d799ed23c7688b501a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_3b15da76251f49d799ed23c7688b501a(_5fcdcb823c64d3e49857f978c5b2a701_3b15da76251f49d799ed23c7688b501a command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_a0654355209144a68a5d4a63902f2eb5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_a0654355209144a68a5d4a63902f2eb5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_a0654355209144a68a5d4a63902f2eb5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_a0654355209144a68a5d4a63902f2eb5(_5fcdcb823c64d3e49857f978c5b2a701_a0654355209144a68a5d4a63902f2eb5 command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_cdbd62a487ca43de82f54ff2d5e85f40(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_cdbd62a487ca43de82f54ff2d5e85f40(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_cdbd62a487ca43de82f54ff2d5e85f40(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_cdbd62a487ca43de82f54ff2d5e85f40(_5fcdcb823c64d3e49857f978c5b2a701_cdbd62a487ca43de82f54ff2d5e85f40 command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_cdb7eff9497340359204a65956e0a05b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_cdb7eff9497340359204a65956e0a05b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_cdb7eff9497340359204a65956e0a05b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_cdb7eff9497340359204a65956e0a05b(_5fcdcb823c64d3e49857f978c5b2a701_cdb7eff9497340359204a65956e0a05b command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_bc6459964362448a862d751f3da1b2e2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_bc6459964362448a862d751f3da1b2e2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_bc6459964362448a862d751f3da1b2e2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_bc6459964362448a862d751f3da1b2e2(_5fcdcb823c64d3e49857f978c5b2a701_bc6459964362448a862d751f3da1b2e2 command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_44419c123a64435ab81d865a0b6708c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_44419c123a64435ab81d865a0b6708c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_44419c123a64435ab81d865a0b6708c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_44419c123a64435ab81d865a0b6708c6(_5fcdcb823c64d3e49857f978c5b2a701_44419c123a64435ab81d865a0b6708c6 command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_d56404cdeb6f4b558489bb1b7f3ef0d5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_d56404cdeb6f4b558489bb1b7f3ef0d5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_d56404cdeb6f4b558489bb1b7f3ef0d5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_d56404cdeb6f4b558489bb1b7f3ef0d5(_5fcdcb823c64d3e49857f978c5b2a701_d56404cdeb6f4b558489bb1b7f3ef0d5 command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_b6d61d5392b34f1e892a87c675615d85(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_b6d61d5392b34f1e892a87c675615d85(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_b6d61d5392b34f1e892a87c675615d85(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_b6d61d5392b34f1e892a87c675615d85(_5fcdcb823c64d3e49857f978c5b2a701_b6d61d5392b34f1e892a87c675615d85 command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_9a5b2b924c3448f6b053994b80636e23(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_9a5b2b924c3448f6b053994b80636e23(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_9a5b2b924c3448f6b053994b80636e23(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_9a5b2b924c3448f6b053994b80636e23(_5fcdcb823c64d3e49857f978c5b2a701_9a5b2b924c3448f6b053994b80636e23 command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_cc43edf558844874a8970a6faf1efe5b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_cc43edf558844874a8970a6faf1efe5b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_cc43edf558844874a8970a6faf1efe5b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_cc43edf558844874a8970a6faf1efe5b(_5fcdcb823c64d3e49857f978c5b2a701_cc43edf558844874a8970a6faf1efe5b command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_821021e9f76548178c7567bdce480fc6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_821021e9f76548178c7567bdce480fc6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_821021e9f76548178c7567bdce480fc6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_821021e9f76548178c7567bdce480fc6(_5fcdcb823c64d3e49857f978c5b2a701_821021e9f76548178c7567bdce480fc6 command)
		{
		}

		private void BakeCommandBinding__5fcdcb823c64d3e49857f978c5b2a701_3c27d8c8557941819a68725fd81b83bc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5fcdcb823c64d3e49857f978c5b2a701_3c27d8c8557941819a68725fd81b83bc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5fcdcb823c64d3e49857f978c5b2a701_3c27d8c8557941819a68725fd81b83bc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5fcdcb823c64d3e49857f978c5b2a701_3c27d8c8557941819a68725fd81b83bc(_5fcdcb823c64d3e49857f978c5b2a701_3c27d8c8557941819a68725fd81b83bc command)
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
