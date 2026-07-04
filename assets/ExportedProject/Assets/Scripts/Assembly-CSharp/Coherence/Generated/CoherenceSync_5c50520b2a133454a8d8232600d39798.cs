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
	public class CoherenceSync_5c50520b2a133454a8d8232600d39798 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _5c50520b2a133454a8d8232600d39798_04e124fdb1cd453f933b05e23224e95a_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_38d399a820bf4c6ba541c782996dee0e_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_efe6a7ac9d0f40db8990e25b4981d838_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_d5edc8c38e834e12962320b1a1815cdb_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_cacf88b94885446cbc47d354545f424f_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_2bd16888286540b5bb0665c4259b732b_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_abe4ed2f50d145a984cf12fa939aae78_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_93e695667f734759ac2786e0da150a58_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_5a23e53f8630446bafdfa388d10778a3_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_41851a8c73cb4824ad027a6ecfe42597_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_19e11bb10fe94e33a9f8d0e3ddeb3a96_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_fec87f3201e6474a9e147a7fa603abf2_CommandTarget;

		private CharacterController _5c50520b2a133454a8d8232600d39798_c5536f81dddf4d598356e5e0e145ffc8_CommandTarget;

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

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_04e124fdb1cd453f933b05e23224e95a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_04e124fdb1cd453f933b05e23224e95a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_04e124fdb1cd453f933b05e23224e95a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_04e124fdb1cd453f933b05e23224e95a(_5c50520b2a133454a8d8232600d39798_04e124fdb1cd453f933b05e23224e95a command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_38d399a820bf4c6ba541c782996dee0e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_38d399a820bf4c6ba541c782996dee0e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_38d399a820bf4c6ba541c782996dee0e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_38d399a820bf4c6ba541c782996dee0e(_5c50520b2a133454a8d8232600d39798_38d399a820bf4c6ba541c782996dee0e command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_efe6a7ac9d0f40db8990e25b4981d838(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_efe6a7ac9d0f40db8990e25b4981d838(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_efe6a7ac9d0f40db8990e25b4981d838(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_efe6a7ac9d0f40db8990e25b4981d838(_5c50520b2a133454a8d8232600d39798_efe6a7ac9d0f40db8990e25b4981d838 command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_d5edc8c38e834e12962320b1a1815cdb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_d5edc8c38e834e12962320b1a1815cdb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_d5edc8c38e834e12962320b1a1815cdb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_d5edc8c38e834e12962320b1a1815cdb(_5c50520b2a133454a8d8232600d39798_d5edc8c38e834e12962320b1a1815cdb command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_cacf88b94885446cbc47d354545f424f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_cacf88b94885446cbc47d354545f424f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_cacf88b94885446cbc47d354545f424f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_cacf88b94885446cbc47d354545f424f(_5c50520b2a133454a8d8232600d39798_cacf88b94885446cbc47d354545f424f command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_2bd16888286540b5bb0665c4259b732b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_2bd16888286540b5bb0665c4259b732b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_2bd16888286540b5bb0665c4259b732b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_2bd16888286540b5bb0665c4259b732b(_5c50520b2a133454a8d8232600d39798_2bd16888286540b5bb0665c4259b732b command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_abe4ed2f50d145a984cf12fa939aae78(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_abe4ed2f50d145a984cf12fa939aae78(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_abe4ed2f50d145a984cf12fa939aae78(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_abe4ed2f50d145a984cf12fa939aae78(_5c50520b2a133454a8d8232600d39798_abe4ed2f50d145a984cf12fa939aae78 command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_93e695667f734759ac2786e0da150a58(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_93e695667f734759ac2786e0da150a58(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_93e695667f734759ac2786e0da150a58(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_93e695667f734759ac2786e0da150a58(_5c50520b2a133454a8d8232600d39798_93e695667f734759ac2786e0da150a58 command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_5a23e53f8630446bafdfa388d10778a3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_5a23e53f8630446bafdfa388d10778a3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_5a23e53f8630446bafdfa388d10778a3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_5a23e53f8630446bafdfa388d10778a3(_5c50520b2a133454a8d8232600d39798_5a23e53f8630446bafdfa388d10778a3 command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_41851a8c73cb4824ad027a6ecfe42597(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_41851a8c73cb4824ad027a6ecfe42597(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_41851a8c73cb4824ad027a6ecfe42597(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_41851a8c73cb4824ad027a6ecfe42597(_5c50520b2a133454a8d8232600d39798_41851a8c73cb4824ad027a6ecfe42597 command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_19e11bb10fe94e33a9f8d0e3ddeb3a96(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_19e11bb10fe94e33a9f8d0e3ddeb3a96(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_19e11bb10fe94e33a9f8d0e3ddeb3a96(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_19e11bb10fe94e33a9f8d0e3ddeb3a96(_5c50520b2a133454a8d8232600d39798_19e11bb10fe94e33a9f8d0e3ddeb3a96 command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_fec87f3201e6474a9e147a7fa603abf2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_fec87f3201e6474a9e147a7fa603abf2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_fec87f3201e6474a9e147a7fa603abf2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_fec87f3201e6474a9e147a7fa603abf2(_5c50520b2a133454a8d8232600d39798_fec87f3201e6474a9e147a7fa603abf2 command)
		{
		}

		private void BakeCommandBinding__5c50520b2a133454a8d8232600d39798_c5536f81dddf4d598356e5e0e145ffc8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c50520b2a133454a8d8232600d39798_c5536f81dddf4d598356e5e0e145ffc8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c50520b2a133454a8d8232600d39798_c5536f81dddf4d598356e5e0e145ffc8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c50520b2a133454a8d8232600d39798_c5536f81dddf4d598356e5e0e145ffc8(_5c50520b2a133454a8d8232600d39798_c5536f81dddf4d598356e5e0e145ffc8 command)
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
