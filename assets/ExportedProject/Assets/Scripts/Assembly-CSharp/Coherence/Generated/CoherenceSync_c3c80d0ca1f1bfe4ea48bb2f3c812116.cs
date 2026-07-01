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
	public class CoherenceSync_c3c80d0ca1f1bfe4ea48bb2f3c812116 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_66d5126b118843acaa2e39d13e737b5b_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_b4813d8b93624b839a90ddd717e1a3ef_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_a52eba5ba0394099b35de7370c14b109_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_8d0900e0e2834a44a90ab2f7a7761e1f_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_418552facdb149da94c0575fe7f2ff70_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_ce88574154e844f2b50a9582bde96d7f_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_985646de2882486290aa6790ed42e1b0_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_279ae42a040940c7ad793268bf948c79_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_393da424424e4c8c83ae6ba0bc03f63a_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_2ae10463386444fbbb802252d645ecc0_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_4e4e9092b36c4f2d823814b0c63109ec_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_d35946d1c0d04bf0ab53ba306934e36e_CommandTarget;

		private CharacterController _c3c80d0ca1f1bfe4ea48bb2f3c812116_b8ada0c88a3c48fdbafee7c051c292a1_CommandTarget;

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

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_66d5126b118843acaa2e39d13e737b5b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_66d5126b118843acaa2e39d13e737b5b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_66d5126b118843acaa2e39d13e737b5b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_66d5126b118843acaa2e39d13e737b5b(_c3c80d0ca1f1bfe4ea48bb2f3c812116_66d5126b118843acaa2e39d13e737b5b command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_b4813d8b93624b839a90ddd717e1a3ef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_b4813d8b93624b839a90ddd717e1a3ef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_b4813d8b93624b839a90ddd717e1a3ef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_b4813d8b93624b839a90ddd717e1a3ef(_c3c80d0ca1f1bfe4ea48bb2f3c812116_b4813d8b93624b839a90ddd717e1a3ef command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_a52eba5ba0394099b35de7370c14b109(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_a52eba5ba0394099b35de7370c14b109(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_a52eba5ba0394099b35de7370c14b109(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_a52eba5ba0394099b35de7370c14b109(_c3c80d0ca1f1bfe4ea48bb2f3c812116_a52eba5ba0394099b35de7370c14b109 command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_8d0900e0e2834a44a90ab2f7a7761e1f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_8d0900e0e2834a44a90ab2f7a7761e1f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_8d0900e0e2834a44a90ab2f7a7761e1f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_8d0900e0e2834a44a90ab2f7a7761e1f(_c3c80d0ca1f1bfe4ea48bb2f3c812116_8d0900e0e2834a44a90ab2f7a7761e1f command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_418552facdb149da94c0575fe7f2ff70(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_418552facdb149da94c0575fe7f2ff70(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_418552facdb149da94c0575fe7f2ff70(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_418552facdb149da94c0575fe7f2ff70(_c3c80d0ca1f1bfe4ea48bb2f3c812116_418552facdb149da94c0575fe7f2ff70 command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_ce88574154e844f2b50a9582bde96d7f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_ce88574154e844f2b50a9582bde96d7f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_ce88574154e844f2b50a9582bde96d7f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_ce88574154e844f2b50a9582bde96d7f(_c3c80d0ca1f1bfe4ea48bb2f3c812116_ce88574154e844f2b50a9582bde96d7f command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_985646de2882486290aa6790ed42e1b0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_985646de2882486290aa6790ed42e1b0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_985646de2882486290aa6790ed42e1b0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_985646de2882486290aa6790ed42e1b0(_c3c80d0ca1f1bfe4ea48bb2f3c812116_985646de2882486290aa6790ed42e1b0 command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_279ae42a040940c7ad793268bf948c79(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_279ae42a040940c7ad793268bf948c79(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_279ae42a040940c7ad793268bf948c79(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_279ae42a040940c7ad793268bf948c79(_c3c80d0ca1f1bfe4ea48bb2f3c812116_279ae42a040940c7ad793268bf948c79 command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_393da424424e4c8c83ae6ba0bc03f63a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_393da424424e4c8c83ae6ba0bc03f63a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_393da424424e4c8c83ae6ba0bc03f63a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_393da424424e4c8c83ae6ba0bc03f63a(_c3c80d0ca1f1bfe4ea48bb2f3c812116_393da424424e4c8c83ae6ba0bc03f63a command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_2ae10463386444fbbb802252d645ecc0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_2ae10463386444fbbb802252d645ecc0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_2ae10463386444fbbb802252d645ecc0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_2ae10463386444fbbb802252d645ecc0(_c3c80d0ca1f1bfe4ea48bb2f3c812116_2ae10463386444fbbb802252d645ecc0 command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_4e4e9092b36c4f2d823814b0c63109ec(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_4e4e9092b36c4f2d823814b0c63109ec(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_4e4e9092b36c4f2d823814b0c63109ec(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_4e4e9092b36c4f2d823814b0c63109ec(_c3c80d0ca1f1bfe4ea48bb2f3c812116_4e4e9092b36c4f2d823814b0c63109ec command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_d35946d1c0d04bf0ab53ba306934e36e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_d35946d1c0d04bf0ab53ba306934e36e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_d35946d1c0d04bf0ab53ba306934e36e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_d35946d1c0d04bf0ab53ba306934e36e(_c3c80d0ca1f1bfe4ea48bb2f3c812116_d35946d1c0d04bf0ab53ba306934e36e command)
		{
		}

		private void BakeCommandBinding__c3c80d0ca1f1bfe4ea48bb2f3c812116_b8ada0c88a3c48fdbafee7c051c292a1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_b8ada0c88a3c48fdbafee7c051c292a1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_b8ada0c88a3c48fdbafee7c051c292a1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c3c80d0ca1f1bfe4ea48bb2f3c812116_b8ada0c88a3c48fdbafee7c051c292a1(_c3c80d0ca1f1bfe4ea48bb2f3c812116_b8ada0c88a3c48fdbafee7c051c292a1 command)
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
