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
	public class CoherenceSync_62070839e717b7b41a86efad06b9f5e6 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_f0be535c926747fba62030b674512c55_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_f80afe615f314f5f8c25a3a9edae9419_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_a74ca36a91404014891ec5d4a3886188_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_dace7e2531d0449fb4517972b94a7f90_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_2073e74b720c4003b26b0f75cd43e0ac_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_dd235ca968c84169954b4c115937462e_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_197fa6c8c4c344daa26cd107401c3d5b_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_1e91505354204f8e86c0ef63618cb704_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_46b438e98b454c91ac0bece941c7d44e_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_de65aa9888a24bc8b33f94ac637ae719_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_2c346e0628544f1ba68693b2c924ec5c_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_8b13d6b685284d6c8b3b85f6f9943994_CommandTarget;

		private CharacterController _62070839e717b7b41a86efad06b9f5e6_83c19926006a44dc8d9a4e5641b5d349_CommandTarget;

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

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_f0be535c926747fba62030b674512c55(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_f0be535c926747fba62030b674512c55(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_f0be535c926747fba62030b674512c55(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_f0be535c926747fba62030b674512c55(_62070839e717b7b41a86efad06b9f5e6_f0be535c926747fba62030b674512c55 command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_f80afe615f314f5f8c25a3a9edae9419(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_f80afe615f314f5f8c25a3a9edae9419(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_f80afe615f314f5f8c25a3a9edae9419(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_f80afe615f314f5f8c25a3a9edae9419(_62070839e717b7b41a86efad06b9f5e6_f80afe615f314f5f8c25a3a9edae9419 command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_a74ca36a91404014891ec5d4a3886188(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_a74ca36a91404014891ec5d4a3886188(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_a74ca36a91404014891ec5d4a3886188(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_a74ca36a91404014891ec5d4a3886188(_62070839e717b7b41a86efad06b9f5e6_a74ca36a91404014891ec5d4a3886188 command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_dace7e2531d0449fb4517972b94a7f90(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_dace7e2531d0449fb4517972b94a7f90(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_dace7e2531d0449fb4517972b94a7f90(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_dace7e2531d0449fb4517972b94a7f90(_62070839e717b7b41a86efad06b9f5e6_dace7e2531d0449fb4517972b94a7f90 command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_2073e74b720c4003b26b0f75cd43e0ac(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_2073e74b720c4003b26b0f75cd43e0ac(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_2073e74b720c4003b26b0f75cd43e0ac(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_2073e74b720c4003b26b0f75cd43e0ac(_62070839e717b7b41a86efad06b9f5e6_2073e74b720c4003b26b0f75cd43e0ac command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_dd235ca968c84169954b4c115937462e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_dd235ca968c84169954b4c115937462e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_dd235ca968c84169954b4c115937462e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_dd235ca968c84169954b4c115937462e(_62070839e717b7b41a86efad06b9f5e6_dd235ca968c84169954b4c115937462e command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_197fa6c8c4c344daa26cd107401c3d5b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_197fa6c8c4c344daa26cd107401c3d5b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_197fa6c8c4c344daa26cd107401c3d5b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_197fa6c8c4c344daa26cd107401c3d5b(_62070839e717b7b41a86efad06b9f5e6_197fa6c8c4c344daa26cd107401c3d5b command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_1e91505354204f8e86c0ef63618cb704(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_1e91505354204f8e86c0ef63618cb704(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_1e91505354204f8e86c0ef63618cb704(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_1e91505354204f8e86c0ef63618cb704(_62070839e717b7b41a86efad06b9f5e6_1e91505354204f8e86c0ef63618cb704 command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_46b438e98b454c91ac0bece941c7d44e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_46b438e98b454c91ac0bece941c7d44e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_46b438e98b454c91ac0bece941c7d44e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_46b438e98b454c91ac0bece941c7d44e(_62070839e717b7b41a86efad06b9f5e6_46b438e98b454c91ac0bece941c7d44e command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_de65aa9888a24bc8b33f94ac637ae719(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_de65aa9888a24bc8b33f94ac637ae719(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_de65aa9888a24bc8b33f94ac637ae719(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_de65aa9888a24bc8b33f94ac637ae719(_62070839e717b7b41a86efad06b9f5e6_de65aa9888a24bc8b33f94ac637ae719 command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_2c346e0628544f1ba68693b2c924ec5c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_2c346e0628544f1ba68693b2c924ec5c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_2c346e0628544f1ba68693b2c924ec5c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_2c346e0628544f1ba68693b2c924ec5c(_62070839e717b7b41a86efad06b9f5e6_2c346e0628544f1ba68693b2c924ec5c command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_8b13d6b685284d6c8b3b85f6f9943994(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_8b13d6b685284d6c8b3b85f6f9943994(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_8b13d6b685284d6c8b3b85f6f9943994(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_8b13d6b685284d6c8b3b85f6f9943994(_62070839e717b7b41a86efad06b9f5e6_8b13d6b685284d6c8b3b85f6f9943994 command)
		{
		}

		private void BakeCommandBinding__62070839e717b7b41a86efad06b9f5e6_83c19926006a44dc8d9a4e5641b5d349(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__62070839e717b7b41a86efad06b9f5e6_83c19926006a44dc8d9a4e5641b5d349(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__62070839e717b7b41a86efad06b9f5e6_83c19926006a44dc8d9a4e5641b5d349(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__62070839e717b7b41a86efad06b9f5e6_83c19926006a44dc8d9a4e5641b5d349(_62070839e717b7b41a86efad06b9f5e6_83c19926006a44dc8d9a4e5641b5d349 command)
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
