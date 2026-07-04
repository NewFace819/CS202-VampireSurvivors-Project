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
	public class CoherenceSync_e1497f19703ce734bbe3e00dc1410741 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_01892a98a19f45ba9d94eb52d9e46ba8_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_26876720e9304e8bad2d579ccd4fd51d_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_c6664288fd5b4435aba7047681703804_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_667bd1c62fb14ea8a832d796d5db6c83_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_7690a93a049d4ef0b26e16f365318a2a_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_7515ecd7d6eb44839c6ec79cc90d3b0a_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_c518226b9b2c40bf8b4cf40569959ee0_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_d2bc1299070947c6a38c4dcaeff1cc97_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_e4452016a5ce42e3be3dbf41d9466b96_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_96c43c4ed29543bd923be17786b3f39c_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_b4d0aa95294442c7b96b433042e915d3_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_9028a0f05ffc41e3929e232dfe78ebc6_CommandTarget;

		private CharacterController _e1497f19703ce734bbe3e00dc1410741_e5a200a380154e1d94fa31d470ed74f1_CommandTarget;

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

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_01892a98a19f45ba9d94eb52d9e46ba8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_01892a98a19f45ba9d94eb52d9e46ba8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_01892a98a19f45ba9d94eb52d9e46ba8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_01892a98a19f45ba9d94eb52d9e46ba8(_e1497f19703ce734bbe3e00dc1410741_01892a98a19f45ba9d94eb52d9e46ba8 command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_26876720e9304e8bad2d579ccd4fd51d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_26876720e9304e8bad2d579ccd4fd51d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_26876720e9304e8bad2d579ccd4fd51d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_26876720e9304e8bad2d579ccd4fd51d(_e1497f19703ce734bbe3e00dc1410741_26876720e9304e8bad2d579ccd4fd51d command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_c6664288fd5b4435aba7047681703804(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_c6664288fd5b4435aba7047681703804(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_c6664288fd5b4435aba7047681703804(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_c6664288fd5b4435aba7047681703804(_e1497f19703ce734bbe3e00dc1410741_c6664288fd5b4435aba7047681703804 command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_667bd1c62fb14ea8a832d796d5db6c83(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_667bd1c62fb14ea8a832d796d5db6c83(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_667bd1c62fb14ea8a832d796d5db6c83(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_667bd1c62fb14ea8a832d796d5db6c83(_e1497f19703ce734bbe3e00dc1410741_667bd1c62fb14ea8a832d796d5db6c83 command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_7690a93a049d4ef0b26e16f365318a2a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_7690a93a049d4ef0b26e16f365318a2a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_7690a93a049d4ef0b26e16f365318a2a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_7690a93a049d4ef0b26e16f365318a2a(_e1497f19703ce734bbe3e00dc1410741_7690a93a049d4ef0b26e16f365318a2a command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_7515ecd7d6eb44839c6ec79cc90d3b0a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_7515ecd7d6eb44839c6ec79cc90d3b0a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_7515ecd7d6eb44839c6ec79cc90d3b0a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_7515ecd7d6eb44839c6ec79cc90d3b0a(_e1497f19703ce734bbe3e00dc1410741_7515ecd7d6eb44839c6ec79cc90d3b0a command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_c518226b9b2c40bf8b4cf40569959ee0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_c518226b9b2c40bf8b4cf40569959ee0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_c518226b9b2c40bf8b4cf40569959ee0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_c518226b9b2c40bf8b4cf40569959ee0(_e1497f19703ce734bbe3e00dc1410741_c518226b9b2c40bf8b4cf40569959ee0 command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_d2bc1299070947c6a38c4dcaeff1cc97(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_d2bc1299070947c6a38c4dcaeff1cc97(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_d2bc1299070947c6a38c4dcaeff1cc97(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_d2bc1299070947c6a38c4dcaeff1cc97(_e1497f19703ce734bbe3e00dc1410741_d2bc1299070947c6a38c4dcaeff1cc97 command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_e4452016a5ce42e3be3dbf41d9466b96(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_e4452016a5ce42e3be3dbf41d9466b96(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_e4452016a5ce42e3be3dbf41d9466b96(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_e4452016a5ce42e3be3dbf41d9466b96(_e1497f19703ce734bbe3e00dc1410741_e4452016a5ce42e3be3dbf41d9466b96 command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_96c43c4ed29543bd923be17786b3f39c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_96c43c4ed29543bd923be17786b3f39c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_96c43c4ed29543bd923be17786b3f39c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_96c43c4ed29543bd923be17786b3f39c(_e1497f19703ce734bbe3e00dc1410741_96c43c4ed29543bd923be17786b3f39c command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_b4d0aa95294442c7b96b433042e915d3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_b4d0aa95294442c7b96b433042e915d3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_b4d0aa95294442c7b96b433042e915d3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_b4d0aa95294442c7b96b433042e915d3(_e1497f19703ce734bbe3e00dc1410741_b4d0aa95294442c7b96b433042e915d3 command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_9028a0f05ffc41e3929e232dfe78ebc6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_9028a0f05ffc41e3929e232dfe78ebc6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_9028a0f05ffc41e3929e232dfe78ebc6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_9028a0f05ffc41e3929e232dfe78ebc6(_e1497f19703ce734bbe3e00dc1410741_9028a0f05ffc41e3929e232dfe78ebc6 command)
		{
		}

		private void BakeCommandBinding__e1497f19703ce734bbe3e00dc1410741_e5a200a380154e1d94fa31d470ed74f1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e1497f19703ce734bbe3e00dc1410741_e5a200a380154e1d94fa31d470ed74f1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e1497f19703ce734bbe3e00dc1410741_e5a200a380154e1d94fa31d470ed74f1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e1497f19703ce734bbe3e00dc1410741_e5a200a380154e1d94fa31d470ed74f1(_e1497f19703ce734bbe3e00dc1410741_e5a200a380154e1d94fa31d470ed74f1 command)
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
