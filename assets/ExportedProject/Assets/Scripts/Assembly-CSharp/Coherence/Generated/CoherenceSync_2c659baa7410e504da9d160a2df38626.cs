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
	public class CoherenceSync_2c659baa7410e504da9d160a2df38626 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _2c659baa7410e504da9d160a2df38626_6e1de86bf2e142aeaaea283f4fc4d055_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_7f0072122976439eb14589b3555aef3b_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_1f324afff9fc4bee9506b1f20d75bc51_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_7d4ccf46b64f4deea733d03533efccc2_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_85cd7893efe74b9bbe2160d2eed957e2_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_69c5ec933c6c4a6e866a940684356c24_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_4f7762ff56bf43239abc33d569886d0c_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_94678b728ee24305a0d56982cd4227e2_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_531ac63b8bbb4fae8f7198ca18ca5d53_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_136f451093ca4417ac9daf59a67875ec_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_00f4ae0add5b48cab4d91ad8bde8428c_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_1e158daa743642838177b94cdc1a0333_CommandTarget;

		private CharacterController _2c659baa7410e504da9d160a2df38626_e8d8e700145545e5956bb97ebb66eeca_CommandTarget;

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

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_6e1de86bf2e142aeaaea283f4fc4d055(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_6e1de86bf2e142aeaaea283f4fc4d055(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_6e1de86bf2e142aeaaea283f4fc4d055(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_6e1de86bf2e142aeaaea283f4fc4d055(_2c659baa7410e504da9d160a2df38626_6e1de86bf2e142aeaaea283f4fc4d055 command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_7f0072122976439eb14589b3555aef3b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_7f0072122976439eb14589b3555aef3b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_7f0072122976439eb14589b3555aef3b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_7f0072122976439eb14589b3555aef3b(_2c659baa7410e504da9d160a2df38626_7f0072122976439eb14589b3555aef3b command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_1f324afff9fc4bee9506b1f20d75bc51(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_1f324afff9fc4bee9506b1f20d75bc51(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_1f324afff9fc4bee9506b1f20d75bc51(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_1f324afff9fc4bee9506b1f20d75bc51(_2c659baa7410e504da9d160a2df38626_1f324afff9fc4bee9506b1f20d75bc51 command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_7d4ccf46b64f4deea733d03533efccc2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_7d4ccf46b64f4deea733d03533efccc2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_7d4ccf46b64f4deea733d03533efccc2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_7d4ccf46b64f4deea733d03533efccc2(_2c659baa7410e504da9d160a2df38626_7d4ccf46b64f4deea733d03533efccc2 command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_85cd7893efe74b9bbe2160d2eed957e2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_85cd7893efe74b9bbe2160d2eed957e2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_85cd7893efe74b9bbe2160d2eed957e2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_85cd7893efe74b9bbe2160d2eed957e2(_2c659baa7410e504da9d160a2df38626_85cd7893efe74b9bbe2160d2eed957e2 command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_69c5ec933c6c4a6e866a940684356c24(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_69c5ec933c6c4a6e866a940684356c24(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_69c5ec933c6c4a6e866a940684356c24(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_69c5ec933c6c4a6e866a940684356c24(_2c659baa7410e504da9d160a2df38626_69c5ec933c6c4a6e866a940684356c24 command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_4f7762ff56bf43239abc33d569886d0c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_4f7762ff56bf43239abc33d569886d0c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_4f7762ff56bf43239abc33d569886d0c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_4f7762ff56bf43239abc33d569886d0c(_2c659baa7410e504da9d160a2df38626_4f7762ff56bf43239abc33d569886d0c command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_94678b728ee24305a0d56982cd4227e2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_94678b728ee24305a0d56982cd4227e2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_94678b728ee24305a0d56982cd4227e2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_94678b728ee24305a0d56982cd4227e2(_2c659baa7410e504da9d160a2df38626_94678b728ee24305a0d56982cd4227e2 command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_531ac63b8bbb4fae8f7198ca18ca5d53(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_531ac63b8bbb4fae8f7198ca18ca5d53(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_531ac63b8bbb4fae8f7198ca18ca5d53(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_531ac63b8bbb4fae8f7198ca18ca5d53(_2c659baa7410e504da9d160a2df38626_531ac63b8bbb4fae8f7198ca18ca5d53 command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_136f451093ca4417ac9daf59a67875ec(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_136f451093ca4417ac9daf59a67875ec(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_136f451093ca4417ac9daf59a67875ec(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_136f451093ca4417ac9daf59a67875ec(_2c659baa7410e504da9d160a2df38626_136f451093ca4417ac9daf59a67875ec command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_00f4ae0add5b48cab4d91ad8bde8428c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_00f4ae0add5b48cab4d91ad8bde8428c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_00f4ae0add5b48cab4d91ad8bde8428c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_00f4ae0add5b48cab4d91ad8bde8428c(_2c659baa7410e504da9d160a2df38626_00f4ae0add5b48cab4d91ad8bde8428c command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_1e158daa743642838177b94cdc1a0333(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_1e158daa743642838177b94cdc1a0333(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_1e158daa743642838177b94cdc1a0333(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_1e158daa743642838177b94cdc1a0333(_2c659baa7410e504da9d160a2df38626_1e158daa743642838177b94cdc1a0333 command)
		{
		}

		private void BakeCommandBinding__2c659baa7410e504da9d160a2df38626_e8d8e700145545e5956bb97ebb66eeca(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c659baa7410e504da9d160a2df38626_e8d8e700145545e5956bb97ebb66eeca(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c659baa7410e504da9d160a2df38626_e8d8e700145545e5956bb97ebb66eeca(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c659baa7410e504da9d160a2df38626_e8d8e700145545e5956bb97ebb66eeca(_2c659baa7410e504da9d160a2df38626_e8d8e700145545e5956bb97ebb66eeca command)
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
