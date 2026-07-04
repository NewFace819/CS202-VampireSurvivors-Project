using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_8ff97a6ad93b99249bb6999eba9c9530 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _8ff97a6ad93b99249bb6999eba9c9530_f3adec66a03045739991f3182221c577_CommandTarget;

		private NetworkPickup _8ff97a6ad93b99249bb6999eba9c9530_f8ebc12f3b4b482690f8dc7660adb315_CommandTarget;

		private NetworkPickup _8ff97a6ad93b99249bb6999eba9c9530_3ae59dd5bb70489796bebedd49fb37b8_CommandTarget;

		private NetworkPickup _8ff97a6ad93b99249bb6999eba9c9530_4ebd0957a4a145beb37454a95ee6fcae_CommandTarget;

		private NetworkPickup _8ff97a6ad93b99249bb6999eba9c9530_d41e4046c00a43028f8a8a4bb81eb991_CommandTarget;

		private NetworkPickup _8ff97a6ad93b99249bb6999eba9c9530_c515fc6cd6f045609d4078f8fa86f9a6_CommandTarget;

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

		private void BakeCommandBinding__8ff97a6ad93b99249bb6999eba9c9530_f3adec66a03045739991f3182221c577(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8ff97a6ad93b99249bb6999eba9c9530_f3adec66a03045739991f3182221c577(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8ff97a6ad93b99249bb6999eba9c9530_f3adec66a03045739991f3182221c577(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8ff97a6ad93b99249bb6999eba9c9530_f3adec66a03045739991f3182221c577(_8ff97a6ad93b99249bb6999eba9c9530_f3adec66a03045739991f3182221c577 command)
		{
		}

		private void BakeCommandBinding__8ff97a6ad93b99249bb6999eba9c9530_f8ebc12f3b4b482690f8dc7660adb315(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8ff97a6ad93b99249bb6999eba9c9530_f8ebc12f3b4b482690f8dc7660adb315(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8ff97a6ad93b99249bb6999eba9c9530_f8ebc12f3b4b482690f8dc7660adb315(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8ff97a6ad93b99249bb6999eba9c9530_f8ebc12f3b4b482690f8dc7660adb315(_8ff97a6ad93b99249bb6999eba9c9530_f8ebc12f3b4b482690f8dc7660adb315 command)
		{
		}

		private void BakeCommandBinding__8ff97a6ad93b99249bb6999eba9c9530_3ae59dd5bb70489796bebedd49fb37b8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8ff97a6ad93b99249bb6999eba9c9530_3ae59dd5bb70489796bebedd49fb37b8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8ff97a6ad93b99249bb6999eba9c9530_3ae59dd5bb70489796bebedd49fb37b8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8ff97a6ad93b99249bb6999eba9c9530_3ae59dd5bb70489796bebedd49fb37b8(_8ff97a6ad93b99249bb6999eba9c9530_3ae59dd5bb70489796bebedd49fb37b8 command)
		{
		}

		private void BakeCommandBinding__8ff97a6ad93b99249bb6999eba9c9530_4ebd0957a4a145beb37454a95ee6fcae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8ff97a6ad93b99249bb6999eba9c9530_4ebd0957a4a145beb37454a95ee6fcae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8ff97a6ad93b99249bb6999eba9c9530_4ebd0957a4a145beb37454a95ee6fcae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8ff97a6ad93b99249bb6999eba9c9530_4ebd0957a4a145beb37454a95ee6fcae(_8ff97a6ad93b99249bb6999eba9c9530_4ebd0957a4a145beb37454a95ee6fcae command)
		{
		}

		private void BakeCommandBinding__8ff97a6ad93b99249bb6999eba9c9530_d41e4046c00a43028f8a8a4bb81eb991(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8ff97a6ad93b99249bb6999eba9c9530_d41e4046c00a43028f8a8a4bb81eb991(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8ff97a6ad93b99249bb6999eba9c9530_d41e4046c00a43028f8a8a4bb81eb991(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8ff97a6ad93b99249bb6999eba9c9530_d41e4046c00a43028f8a8a4bb81eb991(_8ff97a6ad93b99249bb6999eba9c9530_d41e4046c00a43028f8a8a4bb81eb991 command)
		{
		}

		private void BakeCommandBinding__8ff97a6ad93b99249bb6999eba9c9530_c515fc6cd6f045609d4078f8fa86f9a6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8ff97a6ad93b99249bb6999eba9c9530_c515fc6cd6f045609d4078f8fa86f9a6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8ff97a6ad93b99249bb6999eba9c9530_c515fc6cd6f045609d4078f8fa86f9a6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8ff97a6ad93b99249bb6999eba9c9530_c515fc6cd6f045609d4078f8fa86f9a6(_8ff97a6ad93b99249bb6999eba9c9530_c515fc6cd6f045609d4078f8fa86f9a6 command)
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
