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
	public class CoherenceSync_63b75bfcdf0aabe4d955e21fb4a8a741 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_3a40f325a43f4f8088444abe07b27f73_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_c212945d66204fb19682d063314b3d3d_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_800c83252db448b8a654e2ffcb1b7369_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_dab266431ea8496299f50b1cbd6f46fc_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_763f8165a7ce467ebf91cac35b7f2c2c_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_5603fede79ba423f8dae9fe347fc041f_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_853e06b81e584089ae37ab4e23bcbf92_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_f53424a24111467fa4b1969f7645515e_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_8adb093ba2f54a57b5cb02110451de6d_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_25608e3ab9d04feabe9c502e3019f632_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_8608480cebbd4719811f78d019ef58f9_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_77f5639806ce42faa6d6f69ded9070a0_CommandTarget;

		private CharacterController _63b75bfcdf0aabe4d955e21fb4a8a741_0712ccf52a36447c94fddc9c0e3ce954_CommandTarget;

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

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_3a40f325a43f4f8088444abe07b27f73(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_3a40f325a43f4f8088444abe07b27f73(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_3a40f325a43f4f8088444abe07b27f73(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_3a40f325a43f4f8088444abe07b27f73(_63b75bfcdf0aabe4d955e21fb4a8a741_3a40f325a43f4f8088444abe07b27f73 command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_c212945d66204fb19682d063314b3d3d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_c212945d66204fb19682d063314b3d3d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_c212945d66204fb19682d063314b3d3d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_c212945d66204fb19682d063314b3d3d(_63b75bfcdf0aabe4d955e21fb4a8a741_c212945d66204fb19682d063314b3d3d command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_800c83252db448b8a654e2ffcb1b7369(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_800c83252db448b8a654e2ffcb1b7369(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_800c83252db448b8a654e2ffcb1b7369(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_800c83252db448b8a654e2ffcb1b7369(_63b75bfcdf0aabe4d955e21fb4a8a741_800c83252db448b8a654e2ffcb1b7369 command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_dab266431ea8496299f50b1cbd6f46fc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_dab266431ea8496299f50b1cbd6f46fc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_dab266431ea8496299f50b1cbd6f46fc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_dab266431ea8496299f50b1cbd6f46fc(_63b75bfcdf0aabe4d955e21fb4a8a741_dab266431ea8496299f50b1cbd6f46fc command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_763f8165a7ce467ebf91cac35b7f2c2c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_763f8165a7ce467ebf91cac35b7f2c2c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_763f8165a7ce467ebf91cac35b7f2c2c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_763f8165a7ce467ebf91cac35b7f2c2c(_63b75bfcdf0aabe4d955e21fb4a8a741_763f8165a7ce467ebf91cac35b7f2c2c command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_5603fede79ba423f8dae9fe347fc041f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_5603fede79ba423f8dae9fe347fc041f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_5603fede79ba423f8dae9fe347fc041f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_5603fede79ba423f8dae9fe347fc041f(_63b75bfcdf0aabe4d955e21fb4a8a741_5603fede79ba423f8dae9fe347fc041f command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_853e06b81e584089ae37ab4e23bcbf92(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_853e06b81e584089ae37ab4e23bcbf92(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_853e06b81e584089ae37ab4e23bcbf92(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_853e06b81e584089ae37ab4e23bcbf92(_63b75bfcdf0aabe4d955e21fb4a8a741_853e06b81e584089ae37ab4e23bcbf92 command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_f53424a24111467fa4b1969f7645515e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_f53424a24111467fa4b1969f7645515e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_f53424a24111467fa4b1969f7645515e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_f53424a24111467fa4b1969f7645515e(_63b75bfcdf0aabe4d955e21fb4a8a741_f53424a24111467fa4b1969f7645515e command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_8adb093ba2f54a57b5cb02110451de6d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_8adb093ba2f54a57b5cb02110451de6d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_8adb093ba2f54a57b5cb02110451de6d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_8adb093ba2f54a57b5cb02110451de6d(_63b75bfcdf0aabe4d955e21fb4a8a741_8adb093ba2f54a57b5cb02110451de6d command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_25608e3ab9d04feabe9c502e3019f632(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_25608e3ab9d04feabe9c502e3019f632(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_25608e3ab9d04feabe9c502e3019f632(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_25608e3ab9d04feabe9c502e3019f632(_63b75bfcdf0aabe4d955e21fb4a8a741_25608e3ab9d04feabe9c502e3019f632 command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_8608480cebbd4719811f78d019ef58f9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_8608480cebbd4719811f78d019ef58f9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_8608480cebbd4719811f78d019ef58f9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_8608480cebbd4719811f78d019ef58f9(_63b75bfcdf0aabe4d955e21fb4a8a741_8608480cebbd4719811f78d019ef58f9 command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_77f5639806ce42faa6d6f69ded9070a0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_77f5639806ce42faa6d6f69ded9070a0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_77f5639806ce42faa6d6f69ded9070a0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_77f5639806ce42faa6d6f69ded9070a0(_63b75bfcdf0aabe4d955e21fb4a8a741_77f5639806ce42faa6d6f69ded9070a0 command)
		{
		}

		private void BakeCommandBinding__63b75bfcdf0aabe4d955e21fb4a8a741_0712ccf52a36447c94fddc9c0e3ce954(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63b75bfcdf0aabe4d955e21fb4a8a741_0712ccf52a36447c94fddc9c0e3ce954(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63b75bfcdf0aabe4d955e21fb4a8a741_0712ccf52a36447c94fddc9c0e3ce954(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63b75bfcdf0aabe4d955e21fb4a8a741_0712ccf52a36447c94fddc9c0e3ce954(_63b75bfcdf0aabe4d955e21fb4a8a741_0712ccf52a36447c94fddc9c0e3ce954 command)
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
