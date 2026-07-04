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
	public class CoherenceSync_747ff1ebd82204942b96b7d245b11e3a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_c290383057cf44d898e9cbab263ec969_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_9f3bd7c391a84dcd9c7284f161316aa3_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_35a5f453374c453381a847986d7b0c94_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_427a66c045064b6db4f2bf534b254429_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_92a1696336514a3389b78d14cea9deb1_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_3829fa27fa9a4daa8b3ba45abd94b781_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_07f18cce46ce4ad282aa9f8d56075e4d_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_c5aadcd16efa46d682ba6c14a4bdaac5_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_b181bfcb75c84698a7487b2de03e0d60_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_8180839f7b1a4711bceb18348ecc3561_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_064c53af866546128a68d9ea58af7ed7_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_05fc4f30f85b47ffb569325c39d06e4b_CommandTarget;

		private CharacterController _747ff1ebd82204942b96b7d245b11e3a_c423235ca69b4fe7b0f1da8c7c5bda8f_CommandTarget;

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

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_c290383057cf44d898e9cbab263ec969(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_c290383057cf44d898e9cbab263ec969(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_c290383057cf44d898e9cbab263ec969(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_c290383057cf44d898e9cbab263ec969(_747ff1ebd82204942b96b7d245b11e3a_c290383057cf44d898e9cbab263ec969 command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_9f3bd7c391a84dcd9c7284f161316aa3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_9f3bd7c391a84dcd9c7284f161316aa3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_9f3bd7c391a84dcd9c7284f161316aa3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_9f3bd7c391a84dcd9c7284f161316aa3(_747ff1ebd82204942b96b7d245b11e3a_9f3bd7c391a84dcd9c7284f161316aa3 command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_35a5f453374c453381a847986d7b0c94(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_35a5f453374c453381a847986d7b0c94(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_35a5f453374c453381a847986d7b0c94(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_35a5f453374c453381a847986d7b0c94(_747ff1ebd82204942b96b7d245b11e3a_35a5f453374c453381a847986d7b0c94 command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_427a66c045064b6db4f2bf534b254429(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_427a66c045064b6db4f2bf534b254429(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_427a66c045064b6db4f2bf534b254429(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_427a66c045064b6db4f2bf534b254429(_747ff1ebd82204942b96b7d245b11e3a_427a66c045064b6db4f2bf534b254429 command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_92a1696336514a3389b78d14cea9deb1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_92a1696336514a3389b78d14cea9deb1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_92a1696336514a3389b78d14cea9deb1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_92a1696336514a3389b78d14cea9deb1(_747ff1ebd82204942b96b7d245b11e3a_92a1696336514a3389b78d14cea9deb1 command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_3829fa27fa9a4daa8b3ba45abd94b781(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_3829fa27fa9a4daa8b3ba45abd94b781(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_3829fa27fa9a4daa8b3ba45abd94b781(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_3829fa27fa9a4daa8b3ba45abd94b781(_747ff1ebd82204942b96b7d245b11e3a_3829fa27fa9a4daa8b3ba45abd94b781 command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_07f18cce46ce4ad282aa9f8d56075e4d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_07f18cce46ce4ad282aa9f8d56075e4d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_07f18cce46ce4ad282aa9f8d56075e4d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_07f18cce46ce4ad282aa9f8d56075e4d(_747ff1ebd82204942b96b7d245b11e3a_07f18cce46ce4ad282aa9f8d56075e4d command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_c5aadcd16efa46d682ba6c14a4bdaac5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_c5aadcd16efa46d682ba6c14a4bdaac5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_c5aadcd16efa46d682ba6c14a4bdaac5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_c5aadcd16efa46d682ba6c14a4bdaac5(_747ff1ebd82204942b96b7d245b11e3a_c5aadcd16efa46d682ba6c14a4bdaac5 command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_b181bfcb75c84698a7487b2de03e0d60(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_b181bfcb75c84698a7487b2de03e0d60(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_b181bfcb75c84698a7487b2de03e0d60(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_b181bfcb75c84698a7487b2de03e0d60(_747ff1ebd82204942b96b7d245b11e3a_b181bfcb75c84698a7487b2de03e0d60 command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_8180839f7b1a4711bceb18348ecc3561(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_8180839f7b1a4711bceb18348ecc3561(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_8180839f7b1a4711bceb18348ecc3561(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_8180839f7b1a4711bceb18348ecc3561(_747ff1ebd82204942b96b7d245b11e3a_8180839f7b1a4711bceb18348ecc3561 command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_064c53af866546128a68d9ea58af7ed7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_064c53af866546128a68d9ea58af7ed7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_064c53af866546128a68d9ea58af7ed7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_064c53af866546128a68d9ea58af7ed7(_747ff1ebd82204942b96b7d245b11e3a_064c53af866546128a68d9ea58af7ed7 command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_05fc4f30f85b47ffb569325c39d06e4b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_05fc4f30f85b47ffb569325c39d06e4b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_05fc4f30f85b47ffb569325c39d06e4b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_05fc4f30f85b47ffb569325c39d06e4b(_747ff1ebd82204942b96b7d245b11e3a_05fc4f30f85b47ffb569325c39d06e4b command)
		{
		}

		private void BakeCommandBinding__747ff1ebd82204942b96b7d245b11e3a_c423235ca69b4fe7b0f1da8c7c5bda8f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__747ff1ebd82204942b96b7d245b11e3a_c423235ca69b4fe7b0f1da8c7c5bda8f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__747ff1ebd82204942b96b7d245b11e3a_c423235ca69b4fe7b0f1da8c7c5bda8f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__747ff1ebd82204942b96b7d245b11e3a_c423235ca69b4fe7b0f1da8c7c5bda8f(_747ff1ebd82204942b96b7d245b11e3a_c423235ca69b4fe7b0f1da8c7c5bda8f command)
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
