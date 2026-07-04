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
	public class CoherenceSync_b62bc17cb38766e4b8a392a8ce43a0f9 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_01f68279ee9e4a70b6d70f3418699e12_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_ce0a47f508fb42eda095dfdb42992e70_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_76226c5c7cf44a2c8222cdb561d40f82_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_5af5ec3b671e498297d2477598cd253b_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_abb5209cd8ae4a58a44f111d71b42be7_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_5dbd36e6bbca4456af0ed6f2b53b0f3c_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_e3a081c3e337454a838b7c1e49826cd3_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_ca3c6a79fa814de48b7f3a076ffb28b2_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_d8e33bad38de47e589f24df6a9684d40_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_b9b58ca020dc4e8cb2e68fbbf351486a_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_4878a56c3e2341af934411db376e0e90_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_953ac5dddfdc4df2884b37a33db47522_CommandTarget;

		private CharacterController _b62bc17cb38766e4b8a392a8ce43a0f9_6e0fa7dbeae64168ab4296ffa41c21fc_CommandTarget;

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

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_01f68279ee9e4a70b6d70f3418699e12(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_01f68279ee9e4a70b6d70f3418699e12(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_01f68279ee9e4a70b6d70f3418699e12(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_01f68279ee9e4a70b6d70f3418699e12(_b62bc17cb38766e4b8a392a8ce43a0f9_01f68279ee9e4a70b6d70f3418699e12 command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_ce0a47f508fb42eda095dfdb42992e70(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_ce0a47f508fb42eda095dfdb42992e70(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_ce0a47f508fb42eda095dfdb42992e70(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_ce0a47f508fb42eda095dfdb42992e70(_b62bc17cb38766e4b8a392a8ce43a0f9_ce0a47f508fb42eda095dfdb42992e70 command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_76226c5c7cf44a2c8222cdb561d40f82(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_76226c5c7cf44a2c8222cdb561d40f82(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_76226c5c7cf44a2c8222cdb561d40f82(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_76226c5c7cf44a2c8222cdb561d40f82(_b62bc17cb38766e4b8a392a8ce43a0f9_76226c5c7cf44a2c8222cdb561d40f82 command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_5af5ec3b671e498297d2477598cd253b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_5af5ec3b671e498297d2477598cd253b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_5af5ec3b671e498297d2477598cd253b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_5af5ec3b671e498297d2477598cd253b(_b62bc17cb38766e4b8a392a8ce43a0f9_5af5ec3b671e498297d2477598cd253b command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_abb5209cd8ae4a58a44f111d71b42be7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_abb5209cd8ae4a58a44f111d71b42be7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_abb5209cd8ae4a58a44f111d71b42be7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_abb5209cd8ae4a58a44f111d71b42be7(_b62bc17cb38766e4b8a392a8ce43a0f9_abb5209cd8ae4a58a44f111d71b42be7 command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_5dbd36e6bbca4456af0ed6f2b53b0f3c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_5dbd36e6bbca4456af0ed6f2b53b0f3c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_5dbd36e6bbca4456af0ed6f2b53b0f3c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_5dbd36e6bbca4456af0ed6f2b53b0f3c(_b62bc17cb38766e4b8a392a8ce43a0f9_5dbd36e6bbca4456af0ed6f2b53b0f3c command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_e3a081c3e337454a838b7c1e49826cd3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_e3a081c3e337454a838b7c1e49826cd3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_e3a081c3e337454a838b7c1e49826cd3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_e3a081c3e337454a838b7c1e49826cd3(_b62bc17cb38766e4b8a392a8ce43a0f9_e3a081c3e337454a838b7c1e49826cd3 command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_ca3c6a79fa814de48b7f3a076ffb28b2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_ca3c6a79fa814de48b7f3a076ffb28b2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_ca3c6a79fa814de48b7f3a076ffb28b2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_ca3c6a79fa814de48b7f3a076ffb28b2(_b62bc17cb38766e4b8a392a8ce43a0f9_ca3c6a79fa814de48b7f3a076ffb28b2 command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_d8e33bad38de47e589f24df6a9684d40(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_d8e33bad38de47e589f24df6a9684d40(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_d8e33bad38de47e589f24df6a9684d40(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_d8e33bad38de47e589f24df6a9684d40(_b62bc17cb38766e4b8a392a8ce43a0f9_d8e33bad38de47e589f24df6a9684d40 command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_b9b58ca020dc4e8cb2e68fbbf351486a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_b9b58ca020dc4e8cb2e68fbbf351486a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_b9b58ca020dc4e8cb2e68fbbf351486a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_b9b58ca020dc4e8cb2e68fbbf351486a(_b62bc17cb38766e4b8a392a8ce43a0f9_b9b58ca020dc4e8cb2e68fbbf351486a command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_4878a56c3e2341af934411db376e0e90(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_4878a56c3e2341af934411db376e0e90(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_4878a56c3e2341af934411db376e0e90(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_4878a56c3e2341af934411db376e0e90(_b62bc17cb38766e4b8a392a8ce43a0f9_4878a56c3e2341af934411db376e0e90 command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_953ac5dddfdc4df2884b37a33db47522(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_953ac5dddfdc4df2884b37a33db47522(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_953ac5dddfdc4df2884b37a33db47522(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_953ac5dddfdc4df2884b37a33db47522(_b62bc17cb38766e4b8a392a8ce43a0f9_953ac5dddfdc4df2884b37a33db47522 command)
		{
		}

		private void BakeCommandBinding__b62bc17cb38766e4b8a392a8ce43a0f9_6e0fa7dbeae64168ab4296ffa41c21fc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b62bc17cb38766e4b8a392a8ce43a0f9_6e0fa7dbeae64168ab4296ffa41c21fc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b62bc17cb38766e4b8a392a8ce43a0f9_6e0fa7dbeae64168ab4296ffa41c21fc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b62bc17cb38766e4b8a392a8ce43a0f9_6e0fa7dbeae64168ab4296ffa41c21fc(_b62bc17cb38766e4b8a392a8ce43a0f9_6e0fa7dbeae64168ab4296ffa41c21fc command)
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
