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
	public class CoherenceSync_e70c46c802e9ae84981cf99734418104 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _e70c46c802e9ae84981cf99734418104_5e2150bd804f4c1c95971a82d6968184_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_83868ff78b3049b2aab03c3a8873d0a8_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_7276063cbaf04a339109e8492132a16a_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_32befcbb8116465da0a7899707e972f4_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_60bd7139233144d7994d1c699cfb6ffa_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_3a790de638ba413d991db9279e8cd8c8_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_caa558497f914c9fb8c007248e38bde8_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_69719d12296c4421b97d75d83bae98c7_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_34a306067d8a43feaf4512b37dab70da_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_28da2fbf8b73419a962cdbc7b75a26b0_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_55b827cda3024f4997074d7ee660c38d_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_55013d4e21454e5c8e285ab6c594fb60_CommandTarget;

		private CharacterController _e70c46c802e9ae84981cf99734418104_c79724f007ba41c9b730242ba28f4115_CommandTarget;

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

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_5e2150bd804f4c1c95971a82d6968184(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_5e2150bd804f4c1c95971a82d6968184(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_5e2150bd804f4c1c95971a82d6968184(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_5e2150bd804f4c1c95971a82d6968184(_e70c46c802e9ae84981cf99734418104_5e2150bd804f4c1c95971a82d6968184 command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_83868ff78b3049b2aab03c3a8873d0a8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_83868ff78b3049b2aab03c3a8873d0a8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_83868ff78b3049b2aab03c3a8873d0a8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_83868ff78b3049b2aab03c3a8873d0a8(_e70c46c802e9ae84981cf99734418104_83868ff78b3049b2aab03c3a8873d0a8 command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_7276063cbaf04a339109e8492132a16a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_7276063cbaf04a339109e8492132a16a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_7276063cbaf04a339109e8492132a16a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_7276063cbaf04a339109e8492132a16a(_e70c46c802e9ae84981cf99734418104_7276063cbaf04a339109e8492132a16a command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_32befcbb8116465da0a7899707e972f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_32befcbb8116465da0a7899707e972f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_32befcbb8116465da0a7899707e972f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_32befcbb8116465da0a7899707e972f4(_e70c46c802e9ae84981cf99734418104_32befcbb8116465da0a7899707e972f4 command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_60bd7139233144d7994d1c699cfb6ffa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_60bd7139233144d7994d1c699cfb6ffa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_60bd7139233144d7994d1c699cfb6ffa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_60bd7139233144d7994d1c699cfb6ffa(_e70c46c802e9ae84981cf99734418104_60bd7139233144d7994d1c699cfb6ffa command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_3a790de638ba413d991db9279e8cd8c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_3a790de638ba413d991db9279e8cd8c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_3a790de638ba413d991db9279e8cd8c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_3a790de638ba413d991db9279e8cd8c8(_e70c46c802e9ae84981cf99734418104_3a790de638ba413d991db9279e8cd8c8 command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_caa558497f914c9fb8c007248e38bde8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_caa558497f914c9fb8c007248e38bde8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_caa558497f914c9fb8c007248e38bde8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_caa558497f914c9fb8c007248e38bde8(_e70c46c802e9ae84981cf99734418104_caa558497f914c9fb8c007248e38bde8 command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_69719d12296c4421b97d75d83bae98c7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_69719d12296c4421b97d75d83bae98c7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_69719d12296c4421b97d75d83bae98c7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_69719d12296c4421b97d75d83bae98c7(_e70c46c802e9ae84981cf99734418104_69719d12296c4421b97d75d83bae98c7 command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_34a306067d8a43feaf4512b37dab70da(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_34a306067d8a43feaf4512b37dab70da(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_34a306067d8a43feaf4512b37dab70da(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_34a306067d8a43feaf4512b37dab70da(_e70c46c802e9ae84981cf99734418104_34a306067d8a43feaf4512b37dab70da command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_28da2fbf8b73419a962cdbc7b75a26b0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_28da2fbf8b73419a962cdbc7b75a26b0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_28da2fbf8b73419a962cdbc7b75a26b0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_28da2fbf8b73419a962cdbc7b75a26b0(_e70c46c802e9ae84981cf99734418104_28da2fbf8b73419a962cdbc7b75a26b0 command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_55b827cda3024f4997074d7ee660c38d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_55b827cda3024f4997074d7ee660c38d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_55b827cda3024f4997074d7ee660c38d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_55b827cda3024f4997074d7ee660c38d(_e70c46c802e9ae84981cf99734418104_55b827cda3024f4997074d7ee660c38d command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_55013d4e21454e5c8e285ab6c594fb60(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_55013d4e21454e5c8e285ab6c594fb60(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_55013d4e21454e5c8e285ab6c594fb60(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_55013d4e21454e5c8e285ab6c594fb60(_e70c46c802e9ae84981cf99734418104_55013d4e21454e5c8e285ab6c594fb60 command)
		{
		}

		private void BakeCommandBinding__e70c46c802e9ae84981cf99734418104_c79724f007ba41c9b730242ba28f4115(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e70c46c802e9ae84981cf99734418104_c79724f007ba41c9b730242ba28f4115(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e70c46c802e9ae84981cf99734418104_c79724f007ba41c9b730242ba28f4115(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e70c46c802e9ae84981cf99734418104_c79724f007ba41c9b730242ba28f4115(_e70c46c802e9ae84981cf99734418104_c79724f007ba41c9b730242ba28f4115 command)
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
