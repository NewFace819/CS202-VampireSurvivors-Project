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
	public class CoherenceSync_69ab93d4859ed174bacfc548c4e51e06 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_01d08b17ee9c4d85bba526ec19c98594_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_b2ff9c693e2a4813b86ea9cc7fc4d8de_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_754654da48a140908d16617a91a16b4f_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_346f4b3f188a40b09d3ab169213ea317_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_1366073c2370461d8724d6d75b9b5264_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_1e886eedb1ed46d09adfb3fecbf3be3b_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_3afc88784872496889f5dd31f40f49b4_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_1465931ef80b49c3b764a0fe97268983_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_6ab42448995949d6a1573a6db79d4b46_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_50d2ca5fcaf94680b2b4d42644d89975_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_b4323657b58a4a6085c6083389d414e3_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_60eeb49837ee4687b792e380ea63e770_CommandTarget;

		private CharacterController _69ab93d4859ed174bacfc548c4e51e06_d3d94a64edce458da0ee6220db469bd3_CommandTarget;

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

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_01d08b17ee9c4d85bba526ec19c98594(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_01d08b17ee9c4d85bba526ec19c98594(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_01d08b17ee9c4d85bba526ec19c98594(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_01d08b17ee9c4d85bba526ec19c98594(_69ab93d4859ed174bacfc548c4e51e06_01d08b17ee9c4d85bba526ec19c98594 command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_b2ff9c693e2a4813b86ea9cc7fc4d8de(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_b2ff9c693e2a4813b86ea9cc7fc4d8de(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_b2ff9c693e2a4813b86ea9cc7fc4d8de(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_b2ff9c693e2a4813b86ea9cc7fc4d8de(_69ab93d4859ed174bacfc548c4e51e06_b2ff9c693e2a4813b86ea9cc7fc4d8de command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_754654da48a140908d16617a91a16b4f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_754654da48a140908d16617a91a16b4f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_754654da48a140908d16617a91a16b4f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_754654da48a140908d16617a91a16b4f(_69ab93d4859ed174bacfc548c4e51e06_754654da48a140908d16617a91a16b4f command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_346f4b3f188a40b09d3ab169213ea317(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_346f4b3f188a40b09d3ab169213ea317(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_346f4b3f188a40b09d3ab169213ea317(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_346f4b3f188a40b09d3ab169213ea317(_69ab93d4859ed174bacfc548c4e51e06_346f4b3f188a40b09d3ab169213ea317 command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_1366073c2370461d8724d6d75b9b5264(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_1366073c2370461d8724d6d75b9b5264(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_1366073c2370461d8724d6d75b9b5264(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_1366073c2370461d8724d6d75b9b5264(_69ab93d4859ed174bacfc548c4e51e06_1366073c2370461d8724d6d75b9b5264 command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_1e886eedb1ed46d09adfb3fecbf3be3b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_1e886eedb1ed46d09adfb3fecbf3be3b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_1e886eedb1ed46d09adfb3fecbf3be3b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_1e886eedb1ed46d09adfb3fecbf3be3b(_69ab93d4859ed174bacfc548c4e51e06_1e886eedb1ed46d09adfb3fecbf3be3b command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_3afc88784872496889f5dd31f40f49b4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_3afc88784872496889f5dd31f40f49b4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_3afc88784872496889f5dd31f40f49b4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_3afc88784872496889f5dd31f40f49b4(_69ab93d4859ed174bacfc548c4e51e06_3afc88784872496889f5dd31f40f49b4 command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_1465931ef80b49c3b764a0fe97268983(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_1465931ef80b49c3b764a0fe97268983(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_1465931ef80b49c3b764a0fe97268983(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_1465931ef80b49c3b764a0fe97268983(_69ab93d4859ed174bacfc548c4e51e06_1465931ef80b49c3b764a0fe97268983 command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_6ab42448995949d6a1573a6db79d4b46(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_6ab42448995949d6a1573a6db79d4b46(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_6ab42448995949d6a1573a6db79d4b46(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_6ab42448995949d6a1573a6db79d4b46(_69ab93d4859ed174bacfc548c4e51e06_6ab42448995949d6a1573a6db79d4b46 command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_50d2ca5fcaf94680b2b4d42644d89975(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_50d2ca5fcaf94680b2b4d42644d89975(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_50d2ca5fcaf94680b2b4d42644d89975(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_50d2ca5fcaf94680b2b4d42644d89975(_69ab93d4859ed174bacfc548c4e51e06_50d2ca5fcaf94680b2b4d42644d89975 command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_b4323657b58a4a6085c6083389d414e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_b4323657b58a4a6085c6083389d414e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_b4323657b58a4a6085c6083389d414e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_b4323657b58a4a6085c6083389d414e3(_69ab93d4859ed174bacfc548c4e51e06_b4323657b58a4a6085c6083389d414e3 command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_60eeb49837ee4687b792e380ea63e770(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_60eeb49837ee4687b792e380ea63e770(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_60eeb49837ee4687b792e380ea63e770(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_60eeb49837ee4687b792e380ea63e770(_69ab93d4859ed174bacfc548c4e51e06_60eeb49837ee4687b792e380ea63e770 command)
		{
		}

		private void BakeCommandBinding__69ab93d4859ed174bacfc548c4e51e06_d3d94a64edce458da0ee6220db469bd3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__69ab93d4859ed174bacfc548c4e51e06_d3d94a64edce458da0ee6220db469bd3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__69ab93d4859ed174bacfc548c4e51e06_d3d94a64edce458da0ee6220db469bd3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__69ab93d4859ed174bacfc548c4e51e06_d3d94a64edce458da0ee6220db469bd3(_69ab93d4859ed174bacfc548c4e51e06_d3d94a64edce458da0ee6220db469bd3 command)
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
