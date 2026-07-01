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
	public class CoherenceSync_b06052a15cf60af46a9db04018c90cdb : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _b06052a15cf60af46a9db04018c90cdb_1981262486954058a5a94427e31e68d0_CommandTarget;

		private NetworkPickup _b06052a15cf60af46a9db04018c90cdb_761f3e492c564f36a9ca2826005d7aed_CommandTarget;

		private NetworkPickup _b06052a15cf60af46a9db04018c90cdb_a5385da58562437a8f7fb4b8d93b0bde_CommandTarget;

		private NetworkPickup _b06052a15cf60af46a9db04018c90cdb_1b733c16211a4a1e8c73c65acd0eb2c8_CommandTarget;

		private NetworkPickup _b06052a15cf60af46a9db04018c90cdb_11ca1c9c07254b8e8cc7db02af9fbc85_CommandTarget;

		private NetworkPickup _b06052a15cf60af46a9db04018c90cdb_1f801afd1ce04aa996d86cedc3a417b6_CommandTarget;

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

		private void BakeCommandBinding__b06052a15cf60af46a9db04018c90cdb_1981262486954058a5a94427e31e68d0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b06052a15cf60af46a9db04018c90cdb_1981262486954058a5a94427e31e68d0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b06052a15cf60af46a9db04018c90cdb_1981262486954058a5a94427e31e68d0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b06052a15cf60af46a9db04018c90cdb_1981262486954058a5a94427e31e68d0(_b06052a15cf60af46a9db04018c90cdb_1981262486954058a5a94427e31e68d0 command)
		{
		}

		private void BakeCommandBinding__b06052a15cf60af46a9db04018c90cdb_761f3e492c564f36a9ca2826005d7aed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b06052a15cf60af46a9db04018c90cdb_761f3e492c564f36a9ca2826005d7aed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b06052a15cf60af46a9db04018c90cdb_761f3e492c564f36a9ca2826005d7aed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b06052a15cf60af46a9db04018c90cdb_761f3e492c564f36a9ca2826005d7aed(_b06052a15cf60af46a9db04018c90cdb_761f3e492c564f36a9ca2826005d7aed command)
		{
		}

		private void BakeCommandBinding__b06052a15cf60af46a9db04018c90cdb_a5385da58562437a8f7fb4b8d93b0bde(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b06052a15cf60af46a9db04018c90cdb_a5385da58562437a8f7fb4b8d93b0bde(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b06052a15cf60af46a9db04018c90cdb_a5385da58562437a8f7fb4b8d93b0bde(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b06052a15cf60af46a9db04018c90cdb_a5385da58562437a8f7fb4b8d93b0bde(_b06052a15cf60af46a9db04018c90cdb_a5385da58562437a8f7fb4b8d93b0bde command)
		{
		}

		private void BakeCommandBinding__b06052a15cf60af46a9db04018c90cdb_1b733c16211a4a1e8c73c65acd0eb2c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b06052a15cf60af46a9db04018c90cdb_1b733c16211a4a1e8c73c65acd0eb2c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b06052a15cf60af46a9db04018c90cdb_1b733c16211a4a1e8c73c65acd0eb2c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b06052a15cf60af46a9db04018c90cdb_1b733c16211a4a1e8c73c65acd0eb2c8(_b06052a15cf60af46a9db04018c90cdb_1b733c16211a4a1e8c73c65acd0eb2c8 command)
		{
		}

		private void BakeCommandBinding__b06052a15cf60af46a9db04018c90cdb_11ca1c9c07254b8e8cc7db02af9fbc85(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b06052a15cf60af46a9db04018c90cdb_11ca1c9c07254b8e8cc7db02af9fbc85(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b06052a15cf60af46a9db04018c90cdb_11ca1c9c07254b8e8cc7db02af9fbc85(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b06052a15cf60af46a9db04018c90cdb_11ca1c9c07254b8e8cc7db02af9fbc85(_b06052a15cf60af46a9db04018c90cdb_11ca1c9c07254b8e8cc7db02af9fbc85 command)
		{
		}

		private void BakeCommandBinding__b06052a15cf60af46a9db04018c90cdb_1f801afd1ce04aa996d86cedc3a417b6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b06052a15cf60af46a9db04018c90cdb_1f801afd1ce04aa996d86cedc3a417b6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b06052a15cf60af46a9db04018c90cdb_1f801afd1ce04aa996d86cedc3a417b6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b06052a15cf60af46a9db04018c90cdb_1f801afd1ce04aa996d86cedc3a417b6(_b06052a15cf60af46a9db04018c90cdb_1f801afd1ce04aa996d86cedc3a417b6 command)
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
