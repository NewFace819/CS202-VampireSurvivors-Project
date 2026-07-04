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
	public class CoherenceSync_a2c9116f3af6dc64dab56b96cdecca53 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_e76503e7fe5a44d5908b1386557ed2f2_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_692358a1a7cc49d7997928069d806cb1_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_8e5379be8d0e4182ac5cec62c13de8be_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_9272601369af47bfaacdce4d671d0869_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_d06a2f0f08b44bd2b46ff8c5b39b61b8_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_3fac473a154c44f69103d15df026d9eb_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_54e454a7eef34e169dadc98846299831_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_d2b97e2f642246509dd2a0afb304e1fd_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_635be363b483464dab87f588b9896f1e_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_0b4edcb5718a4babad8d3dc8c590bfb6_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_43b590592e814630baa692e25ec8d0a2_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_a0a7f3d8e1464db6a54d944e16f6e2c8_CommandTarget;

		private CharacterController _a2c9116f3af6dc64dab56b96cdecca53_164c8d933e2e4415b6562eb3cae0d9c3_CommandTarget;

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

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_e76503e7fe5a44d5908b1386557ed2f2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_e76503e7fe5a44d5908b1386557ed2f2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_e76503e7fe5a44d5908b1386557ed2f2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_e76503e7fe5a44d5908b1386557ed2f2(_a2c9116f3af6dc64dab56b96cdecca53_e76503e7fe5a44d5908b1386557ed2f2 command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_692358a1a7cc49d7997928069d806cb1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_692358a1a7cc49d7997928069d806cb1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_692358a1a7cc49d7997928069d806cb1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_692358a1a7cc49d7997928069d806cb1(_a2c9116f3af6dc64dab56b96cdecca53_692358a1a7cc49d7997928069d806cb1 command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_8e5379be8d0e4182ac5cec62c13de8be(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_8e5379be8d0e4182ac5cec62c13de8be(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_8e5379be8d0e4182ac5cec62c13de8be(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_8e5379be8d0e4182ac5cec62c13de8be(_a2c9116f3af6dc64dab56b96cdecca53_8e5379be8d0e4182ac5cec62c13de8be command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_9272601369af47bfaacdce4d671d0869(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_9272601369af47bfaacdce4d671d0869(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_9272601369af47bfaacdce4d671d0869(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_9272601369af47bfaacdce4d671d0869(_a2c9116f3af6dc64dab56b96cdecca53_9272601369af47bfaacdce4d671d0869 command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_d06a2f0f08b44bd2b46ff8c5b39b61b8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_d06a2f0f08b44bd2b46ff8c5b39b61b8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_d06a2f0f08b44bd2b46ff8c5b39b61b8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_d06a2f0f08b44bd2b46ff8c5b39b61b8(_a2c9116f3af6dc64dab56b96cdecca53_d06a2f0f08b44bd2b46ff8c5b39b61b8 command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_3fac473a154c44f69103d15df026d9eb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_3fac473a154c44f69103d15df026d9eb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_3fac473a154c44f69103d15df026d9eb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_3fac473a154c44f69103d15df026d9eb(_a2c9116f3af6dc64dab56b96cdecca53_3fac473a154c44f69103d15df026d9eb command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_54e454a7eef34e169dadc98846299831(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_54e454a7eef34e169dadc98846299831(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_54e454a7eef34e169dadc98846299831(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_54e454a7eef34e169dadc98846299831(_a2c9116f3af6dc64dab56b96cdecca53_54e454a7eef34e169dadc98846299831 command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_d2b97e2f642246509dd2a0afb304e1fd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_d2b97e2f642246509dd2a0afb304e1fd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_d2b97e2f642246509dd2a0afb304e1fd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_d2b97e2f642246509dd2a0afb304e1fd(_a2c9116f3af6dc64dab56b96cdecca53_d2b97e2f642246509dd2a0afb304e1fd command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_635be363b483464dab87f588b9896f1e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_635be363b483464dab87f588b9896f1e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_635be363b483464dab87f588b9896f1e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_635be363b483464dab87f588b9896f1e(_a2c9116f3af6dc64dab56b96cdecca53_635be363b483464dab87f588b9896f1e command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_0b4edcb5718a4babad8d3dc8c590bfb6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_0b4edcb5718a4babad8d3dc8c590bfb6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_0b4edcb5718a4babad8d3dc8c590bfb6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_0b4edcb5718a4babad8d3dc8c590bfb6(_a2c9116f3af6dc64dab56b96cdecca53_0b4edcb5718a4babad8d3dc8c590bfb6 command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_43b590592e814630baa692e25ec8d0a2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_43b590592e814630baa692e25ec8d0a2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_43b590592e814630baa692e25ec8d0a2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_43b590592e814630baa692e25ec8d0a2(_a2c9116f3af6dc64dab56b96cdecca53_43b590592e814630baa692e25ec8d0a2 command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_a0a7f3d8e1464db6a54d944e16f6e2c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_a0a7f3d8e1464db6a54d944e16f6e2c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_a0a7f3d8e1464db6a54d944e16f6e2c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_a0a7f3d8e1464db6a54d944e16f6e2c8(_a2c9116f3af6dc64dab56b96cdecca53_a0a7f3d8e1464db6a54d944e16f6e2c8 command)
		{
		}

		private void BakeCommandBinding__a2c9116f3af6dc64dab56b96cdecca53_164c8d933e2e4415b6562eb3cae0d9c3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2c9116f3af6dc64dab56b96cdecca53_164c8d933e2e4415b6562eb3cae0d9c3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2c9116f3af6dc64dab56b96cdecca53_164c8d933e2e4415b6562eb3cae0d9c3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2c9116f3af6dc64dab56b96cdecca53_164c8d933e2e4415b6562eb3cae0d9c3(_a2c9116f3af6dc64dab56b96cdecca53_164c8d933e2e4415b6562eb3cae0d9c3 command)
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
