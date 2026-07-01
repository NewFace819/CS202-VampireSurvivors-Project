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
	public class CoherenceSync_9dd30fc2395013d408bf881d717d21d9 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_b63d44a7c3e34a6ebd1788c4ee96f138_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_2c7014c8f14c41bfa9a24de02a557888_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_812201f087d4463abc0fb6da4eff43c1_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_eecc85f5ec3043fdb09ae3934457081d_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_8466bf9d22604c5bae12f3993058ed0a_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_8b96052bfb9a4c66b899319a6abfd094_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_55fec281305d4359910e79c847979e8b_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_467e3fdb775c479884590d8c1a66a3cc_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_de9456e23e53407b927a71d3a97b248b_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_32d8a995b8c44311b72bbf3ea8562a20_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_d8d4eee46d03481c9a7824688b6cb16e_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_4570ced8efc7475dbb2c9182397e250a_CommandTarget;

		private CharacterController _9dd30fc2395013d408bf881d717d21d9_199a024854f9450ead6b85f1cedcfbed_CommandTarget;

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

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_b63d44a7c3e34a6ebd1788c4ee96f138(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_b63d44a7c3e34a6ebd1788c4ee96f138(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_b63d44a7c3e34a6ebd1788c4ee96f138(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_b63d44a7c3e34a6ebd1788c4ee96f138(_9dd30fc2395013d408bf881d717d21d9_b63d44a7c3e34a6ebd1788c4ee96f138 command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_2c7014c8f14c41bfa9a24de02a557888(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_2c7014c8f14c41bfa9a24de02a557888(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_2c7014c8f14c41bfa9a24de02a557888(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_2c7014c8f14c41bfa9a24de02a557888(_9dd30fc2395013d408bf881d717d21d9_2c7014c8f14c41bfa9a24de02a557888 command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_812201f087d4463abc0fb6da4eff43c1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_812201f087d4463abc0fb6da4eff43c1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_812201f087d4463abc0fb6da4eff43c1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_812201f087d4463abc0fb6da4eff43c1(_9dd30fc2395013d408bf881d717d21d9_812201f087d4463abc0fb6da4eff43c1 command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_eecc85f5ec3043fdb09ae3934457081d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_eecc85f5ec3043fdb09ae3934457081d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_eecc85f5ec3043fdb09ae3934457081d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_eecc85f5ec3043fdb09ae3934457081d(_9dd30fc2395013d408bf881d717d21d9_eecc85f5ec3043fdb09ae3934457081d command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_8466bf9d22604c5bae12f3993058ed0a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_8466bf9d22604c5bae12f3993058ed0a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_8466bf9d22604c5bae12f3993058ed0a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_8466bf9d22604c5bae12f3993058ed0a(_9dd30fc2395013d408bf881d717d21d9_8466bf9d22604c5bae12f3993058ed0a command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_8b96052bfb9a4c66b899319a6abfd094(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_8b96052bfb9a4c66b899319a6abfd094(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_8b96052bfb9a4c66b899319a6abfd094(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_8b96052bfb9a4c66b899319a6abfd094(_9dd30fc2395013d408bf881d717d21d9_8b96052bfb9a4c66b899319a6abfd094 command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_55fec281305d4359910e79c847979e8b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_55fec281305d4359910e79c847979e8b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_55fec281305d4359910e79c847979e8b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_55fec281305d4359910e79c847979e8b(_9dd30fc2395013d408bf881d717d21d9_55fec281305d4359910e79c847979e8b command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_467e3fdb775c479884590d8c1a66a3cc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_467e3fdb775c479884590d8c1a66a3cc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_467e3fdb775c479884590d8c1a66a3cc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_467e3fdb775c479884590d8c1a66a3cc(_9dd30fc2395013d408bf881d717d21d9_467e3fdb775c479884590d8c1a66a3cc command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_de9456e23e53407b927a71d3a97b248b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_de9456e23e53407b927a71d3a97b248b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_de9456e23e53407b927a71d3a97b248b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_de9456e23e53407b927a71d3a97b248b(_9dd30fc2395013d408bf881d717d21d9_de9456e23e53407b927a71d3a97b248b command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_32d8a995b8c44311b72bbf3ea8562a20(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_32d8a995b8c44311b72bbf3ea8562a20(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_32d8a995b8c44311b72bbf3ea8562a20(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_32d8a995b8c44311b72bbf3ea8562a20(_9dd30fc2395013d408bf881d717d21d9_32d8a995b8c44311b72bbf3ea8562a20 command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_d8d4eee46d03481c9a7824688b6cb16e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_d8d4eee46d03481c9a7824688b6cb16e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_d8d4eee46d03481c9a7824688b6cb16e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_d8d4eee46d03481c9a7824688b6cb16e(_9dd30fc2395013d408bf881d717d21d9_d8d4eee46d03481c9a7824688b6cb16e command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_4570ced8efc7475dbb2c9182397e250a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_4570ced8efc7475dbb2c9182397e250a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_4570ced8efc7475dbb2c9182397e250a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_4570ced8efc7475dbb2c9182397e250a(_9dd30fc2395013d408bf881d717d21d9_4570ced8efc7475dbb2c9182397e250a command)
		{
		}

		private void BakeCommandBinding__9dd30fc2395013d408bf881d717d21d9_199a024854f9450ead6b85f1cedcfbed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9dd30fc2395013d408bf881d717d21d9_199a024854f9450ead6b85f1cedcfbed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9dd30fc2395013d408bf881d717d21d9_199a024854f9450ead6b85f1cedcfbed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9dd30fc2395013d408bf881d717d21d9_199a024854f9450ead6b85f1cedcfbed(_9dd30fc2395013d408bf881d717d21d9_199a024854f9450ead6b85f1cedcfbed command)
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
