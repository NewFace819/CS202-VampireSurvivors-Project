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
	public class CoherenceSync_4af6860640899fa4398db18d20d22593 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _4af6860640899fa4398db18d20d22593_e371e8fb63144191bd6b7efe4c39e4fc_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_21c3315f9dcd40ffa9d22f9e79352e8a_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_9c8b6a6867374114ae4d86b622d92f1f_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_3e90128ac4ae4a6692241a50dbefd03a_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_2446ef98207c42f0a6735c4978abac66_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_1d8c8cc97f434ac1aa57ec2ed06d9adb_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_7d9c72550caf45c8b7dbd406a8b598dd_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_ec9e131865b248df805ffa72fc5061b3_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_c8cd58af29c24fdca5a9f18cf9c0f147_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_6ea24597468445718ed5cebca928973b_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_aff1f002127e4cbc87677a9f6b95b053_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_fd9cb460dd594733bfdd2cc304b7c1bc_CommandTarget;

		private CharacterController _4af6860640899fa4398db18d20d22593_a2dec7f53c2d41319c0816eca014e009_CommandTarget;

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

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_e371e8fb63144191bd6b7efe4c39e4fc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_e371e8fb63144191bd6b7efe4c39e4fc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_e371e8fb63144191bd6b7efe4c39e4fc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_e371e8fb63144191bd6b7efe4c39e4fc(_4af6860640899fa4398db18d20d22593_e371e8fb63144191bd6b7efe4c39e4fc command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_21c3315f9dcd40ffa9d22f9e79352e8a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_21c3315f9dcd40ffa9d22f9e79352e8a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_21c3315f9dcd40ffa9d22f9e79352e8a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_21c3315f9dcd40ffa9d22f9e79352e8a(_4af6860640899fa4398db18d20d22593_21c3315f9dcd40ffa9d22f9e79352e8a command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_9c8b6a6867374114ae4d86b622d92f1f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_9c8b6a6867374114ae4d86b622d92f1f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_9c8b6a6867374114ae4d86b622d92f1f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_9c8b6a6867374114ae4d86b622d92f1f(_4af6860640899fa4398db18d20d22593_9c8b6a6867374114ae4d86b622d92f1f command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_3e90128ac4ae4a6692241a50dbefd03a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_3e90128ac4ae4a6692241a50dbefd03a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_3e90128ac4ae4a6692241a50dbefd03a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_3e90128ac4ae4a6692241a50dbefd03a(_4af6860640899fa4398db18d20d22593_3e90128ac4ae4a6692241a50dbefd03a command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_2446ef98207c42f0a6735c4978abac66(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_2446ef98207c42f0a6735c4978abac66(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_2446ef98207c42f0a6735c4978abac66(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_2446ef98207c42f0a6735c4978abac66(_4af6860640899fa4398db18d20d22593_2446ef98207c42f0a6735c4978abac66 command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_1d8c8cc97f434ac1aa57ec2ed06d9adb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_1d8c8cc97f434ac1aa57ec2ed06d9adb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_1d8c8cc97f434ac1aa57ec2ed06d9adb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_1d8c8cc97f434ac1aa57ec2ed06d9adb(_4af6860640899fa4398db18d20d22593_1d8c8cc97f434ac1aa57ec2ed06d9adb command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_7d9c72550caf45c8b7dbd406a8b598dd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_7d9c72550caf45c8b7dbd406a8b598dd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_7d9c72550caf45c8b7dbd406a8b598dd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_7d9c72550caf45c8b7dbd406a8b598dd(_4af6860640899fa4398db18d20d22593_7d9c72550caf45c8b7dbd406a8b598dd command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_ec9e131865b248df805ffa72fc5061b3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_ec9e131865b248df805ffa72fc5061b3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_ec9e131865b248df805ffa72fc5061b3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_ec9e131865b248df805ffa72fc5061b3(_4af6860640899fa4398db18d20d22593_ec9e131865b248df805ffa72fc5061b3 command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_c8cd58af29c24fdca5a9f18cf9c0f147(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_c8cd58af29c24fdca5a9f18cf9c0f147(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_c8cd58af29c24fdca5a9f18cf9c0f147(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_c8cd58af29c24fdca5a9f18cf9c0f147(_4af6860640899fa4398db18d20d22593_c8cd58af29c24fdca5a9f18cf9c0f147 command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_6ea24597468445718ed5cebca928973b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_6ea24597468445718ed5cebca928973b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_6ea24597468445718ed5cebca928973b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_6ea24597468445718ed5cebca928973b(_4af6860640899fa4398db18d20d22593_6ea24597468445718ed5cebca928973b command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_aff1f002127e4cbc87677a9f6b95b053(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_aff1f002127e4cbc87677a9f6b95b053(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_aff1f002127e4cbc87677a9f6b95b053(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_aff1f002127e4cbc87677a9f6b95b053(_4af6860640899fa4398db18d20d22593_aff1f002127e4cbc87677a9f6b95b053 command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_fd9cb460dd594733bfdd2cc304b7c1bc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_fd9cb460dd594733bfdd2cc304b7c1bc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_fd9cb460dd594733bfdd2cc304b7c1bc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_fd9cb460dd594733bfdd2cc304b7c1bc(_4af6860640899fa4398db18d20d22593_fd9cb460dd594733bfdd2cc304b7c1bc command)
		{
		}

		private void BakeCommandBinding__4af6860640899fa4398db18d20d22593_a2dec7f53c2d41319c0816eca014e009(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4af6860640899fa4398db18d20d22593_a2dec7f53c2d41319c0816eca014e009(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4af6860640899fa4398db18d20d22593_a2dec7f53c2d41319c0816eca014e009(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4af6860640899fa4398db18d20d22593_a2dec7f53c2d41319c0816eca014e009(_4af6860640899fa4398db18d20d22593_a2dec7f53c2d41319c0816eca014e009 command)
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
