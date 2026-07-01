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
	public class CoherenceSync_5333b2a42ab8f694c85cc5b60655d2da : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_afb4acbe35f0422eac5682d1e4080c2d_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_dd5e588d6acf44378a5639bfac5c8b07_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_a3d4817aa5e34d4a916ddabc9232a028_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_8871068567f54fe883662697976c99fc_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_de166a08c89a4b20878627239cc0f6c1_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_923966be6a95427d91341908ea9a3770_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_1ec2bc9951a2432e9355ff6e1272de68_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_e1bbeb7e2be6481ca1aa9da8dc0bf5fd_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_2d5448417b64471d849dce9a73ad73c7_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_28ba2a5d63134beeb1bddbcb0d216bde_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_1fad9a95bc2d403c843ed245258899c6_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_78085a2f8f024e319f524e98fe49619b_CommandTarget;

		private CharacterController _5333b2a42ab8f694c85cc5b60655d2da_aaa4359806354bf99a6c380c7be6745f_CommandTarget;

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

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_afb4acbe35f0422eac5682d1e4080c2d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_afb4acbe35f0422eac5682d1e4080c2d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_afb4acbe35f0422eac5682d1e4080c2d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_afb4acbe35f0422eac5682d1e4080c2d(_5333b2a42ab8f694c85cc5b60655d2da_afb4acbe35f0422eac5682d1e4080c2d command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_dd5e588d6acf44378a5639bfac5c8b07(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_dd5e588d6acf44378a5639bfac5c8b07(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_dd5e588d6acf44378a5639bfac5c8b07(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_dd5e588d6acf44378a5639bfac5c8b07(_5333b2a42ab8f694c85cc5b60655d2da_dd5e588d6acf44378a5639bfac5c8b07 command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_a3d4817aa5e34d4a916ddabc9232a028(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_a3d4817aa5e34d4a916ddabc9232a028(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_a3d4817aa5e34d4a916ddabc9232a028(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_a3d4817aa5e34d4a916ddabc9232a028(_5333b2a42ab8f694c85cc5b60655d2da_a3d4817aa5e34d4a916ddabc9232a028 command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_8871068567f54fe883662697976c99fc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_8871068567f54fe883662697976c99fc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_8871068567f54fe883662697976c99fc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_8871068567f54fe883662697976c99fc(_5333b2a42ab8f694c85cc5b60655d2da_8871068567f54fe883662697976c99fc command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_de166a08c89a4b20878627239cc0f6c1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_de166a08c89a4b20878627239cc0f6c1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_de166a08c89a4b20878627239cc0f6c1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_de166a08c89a4b20878627239cc0f6c1(_5333b2a42ab8f694c85cc5b60655d2da_de166a08c89a4b20878627239cc0f6c1 command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_923966be6a95427d91341908ea9a3770(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_923966be6a95427d91341908ea9a3770(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_923966be6a95427d91341908ea9a3770(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_923966be6a95427d91341908ea9a3770(_5333b2a42ab8f694c85cc5b60655d2da_923966be6a95427d91341908ea9a3770 command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_1ec2bc9951a2432e9355ff6e1272de68(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_1ec2bc9951a2432e9355ff6e1272de68(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_1ec2bc9951a2432e9355ff6e1272de68(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_1ec2bc9951a2432e9355ff6e1272de68(_5333b2a42ab8f694c85cc5b60655d2da_1ec2bc9951a2432e9355ff6e1272de68 command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_e1bbeb7e2be6481ca1aa9da8dc0bf5fd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_e1bbeb7e2be6481ca1aa9da8dc0bf5fd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_e1bbeb7e2be6481ca1aa9da8dc0bf5fd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_e1bbeb7e2be6481ca1aa9da8dc0bf5fd(_5333b2a42ab8f694c85cc5b60655d2da_e1bbeb7e2be6481ca1aa9da8dc0bf5fd command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_2d5448417b64471d849dce9a73ad73c7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_2d5448417b64471d849dce9a73ad73c7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_2d5448417b64471d849dce9a73ad73c7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_2d5448417b64471d849dce9a73ad73c7(_5333b2a42ab8f694c85cc5b60655d2da_2d5448417b64471d849dce9a73ad73c7 command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_28ba2a5d63134beeb1bddbcb0d216bde(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_28ba2a5d63134beeb1bddbcb0d216bde(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_28ba2a5d63134beeb1bddbcb0d216bde(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_28ba2a5d63134beeb1bddbcb0d216bde(_5333b2a42ab8f694c85cc5b60655d2da_28ba2a5d63134beeb1bddbcb0d216bde command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_1fad9a95bc2d403c843ed245258899c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_1fad9a95bc2d403c843ed245258899c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_1fad9a95bc2d403c843ed245258899c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_1fad9a95bc2d403c843ed245258899c6(_5333b2a42ab8f694c85cc5b60655d2da_1fad9a95bc2d403c843ed245258899c6 command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_78085a2f8f024e319f524e98fe49619b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_78085a2f8f024e319f524e98fe49619b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_78085a2f8f024e319f524e98fe49619b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_78085a2f8f024e319f524e98fe49619b(_5333b2a42ab8f694c85cc5b60655d2da_78085a2f8f024e319f524e98fe49619b command)
		{
		}

		private void BakeCommandBinding__5333b2a42ab8f694c85cc5b60655d2da_aaa4359806354bf99a6c380c7be6745f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5333b2a42ab8f694c85cc5b60655d2da_aaa4359806354bf99a6c380c7be6745f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5333b2a42ab8f694c85cc5b60655d2da_aaa4359806354bf99a6c380c7be6745f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5333b2a42ab8f694c85cc5b60655d2da_aaa4359806354bf99a6c380c7be6745f(_5333b2a42ab8f694c85cc5b60655d2da_aaa4359806354bf99a6c380c7be6745f command)
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
