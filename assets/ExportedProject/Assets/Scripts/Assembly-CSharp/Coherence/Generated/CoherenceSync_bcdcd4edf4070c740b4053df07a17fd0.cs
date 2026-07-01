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
	public class CoherenceSync_bcdcd4edf4070c740b4053df07a17fd0 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_4a4d09b5843f4bd7bbc6b935887fc2d0_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_9d2c4a6d59bb4ecf9d42119945809180_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_6c8b1dd3496c4bea85f7d690138929c9_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_726a7d02d7714a7888b43dcdabbfcd33_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_ebc9f89cc750447c8793a84b6800cfa5_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_ff6092483185420db7fe4fbde288e261_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_b9107cfc656149abb4af4117209a8b2f_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_30cd21d7148d4aab92519824b7d6263a_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_45d0aa77fc844345b90e0b1c2275352a_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_26537e26cac540aa855b23c91412b059_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_b09ac41ec48e4881ba344be8db75783c_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_3e6c11d15379476dacbf93ad69a7eb15_CommandTarget;

		private CharacterController _bcdcd4edf4070c740b4053df07a17fd0_85c798c3a2c7498d8dc7e07736980cfc_CommandTarget;

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

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_4a4d09b5843f4bd7bbc6b935887fc2d0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_4a4d09b5843f4bd7bbc6b935887fc2d0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_4a4d09b5843f4bd7bbc6b935887fc2d0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_4a4d09b5843f4bd7bbc6b935887fc2d0(_bcdcd4edf4070c740b4053df07a17fd0_4a4d09b5843f4bd7bbc6b935887fc2d0 command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_9d2c4a6d59bb4ecf9d42119945809180(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_9d2c4a6d59bb4ecf9d42119945809180(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_9d2c4a6d59bb4ecf9d42119945809180(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_9d2c4a6d59bb4ecf9d42119945809180(_bcdcd4edf4070c740b4053df07a17fd0_9d2c4a6d59bb4ecf9d42119945809180 command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_6c8b1dd3496c4bea85f7d690138929c9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_6c8b1dd3496c4bea85f7d690138929c9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_6c8b1dd3496c4bea85f7d690138929c9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_6c8b1dd3496c4bea85f7d690138929c9(_bcdcd4edf4070c740b4053df07a17fd0_6c8b1dd3496c4bea85f7d690138929c9 command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_726a7d02d7714a7888b43dcdabbfcd33(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_726a7d02d7714a7888b43dcdabbfcd33(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_726a7d02d7714a7888b43dcdabbfcd33(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_726a7d02d7714a7888b43dcdabbfcd33(_bcdcd4edf4070c740b4053df07a17fd0_726a7d02d7714a7888b43dcdabbfcd33 command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_ebc9f89cc750447c8793a84b6800cfa5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_ebc9f89cc750447c8793a84b6800cfa5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_ebc9f89cc750447c8793a84b6800cfa5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_ebc9f89cc750447c8793a84b6800cfa5(_bcdcd4edf4070c740b4053df07a17fd0_ebc9f89cc750447c8793a84b6800cfa5 command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_ff6092483185420db7fe4fbde288e261(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_ff6092483185420db7fe4fbde288e261(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_ff6092483185420db7fe4fbde288e261(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_ff6092483185420db7fe4fbde288e261(_bcdcd4edf4070c740b4053df07a17fd0_ff6092483185420db7fe4fbde288e261 command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_b9107cfc656149abb4af4117209a8b2f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_b9107cfc656149abb4af4117209a8b2f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_b9107cfc656149abb4af4117209a8b2f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_b9107cfc656149abb4af4117209a8b2f(_bcdcd4edf4070c740b4053df07a17fd0_b9107cfc656149abb4af4117209a8b2f command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_30cd21d7148d4aab92519824b7d6263a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_30cd21d7148d4aab92519824b7d6263a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_30cd21d7148d4aab92519824b7d6263a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_30cd21d7148d4aab92519824b7d6263a(_bcdcd4edf4070c740b4053df07a17fd0_30cd21d7148d4aab92519824b7d6263a command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_45d0aa77fc844345b90e0b1c2275352a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_45d0aa77fc844345b90e0b1c2275352a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_45d0aa77fc844345b90e0b1c2275352a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_45d0aa77fc844345b90e0b1c2275352a(_bcdcd4edf4070c740b4053df07a17fd0_45d0aa77fc844345b90e0b1c2275352a command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_26537e26cac540aa855b23c91412b059(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_26537e26cac540aa855b23c91412b059(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_26537e26cac540aa855b23c91412b059(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_26537e26cac540aa855b23c91412b059(_bcdcd4edf4070c740b4053df07a17fd0_26537e26cac540aa855b23c91412b059 command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_b09ac41ec48e4881ba344be8db75783c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_b09ac41ec48e4881ba344be8db75783c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_b09ac41ec48e4881ba344be8db75783c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_b09ac41ec48e4881ba344be8db75783c(_bcdcd4edf4070c740b4053df07a17fd0_b09ac41ec48e4881ba344be8db75783c command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_3e6c11d15379476dacbf93ad69a7eb15(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_3e6c11d15379476dacbf93ad69a7eb15(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_3e6c11d15379476dacbf93ad69a7eb15(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_3e6c11d15379476dacbf93ad69a7eb15(_bcdcd4edf4070c740b4053df07a17fd0_3e6c11d15379476dacbf93ad69a7eb15 command)
		{
		}

		private void BakeCommandBinding__bcdcd4edf4070c740b4053df07a17fd0_85c798c3a2c7498d8dc7e07736980cfc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__bcdcd4edf4070c740b4053df07a17fd0_85c798c3a2c7498d8dc7e07736980cfc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__bcdcd4edf4070c740b4053df07a17fd0_85c798c3a2c7498d8dc7e07736980cfc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__bcdcd4edf4070c740b4053df07a17fd0_85c798c3a2c7498d8dc7e07736980cfc(_bcdcd4edf4070c740b4053df07a17fd0_85c798c3a2c7498d8dc7e07736980cfc command)
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
