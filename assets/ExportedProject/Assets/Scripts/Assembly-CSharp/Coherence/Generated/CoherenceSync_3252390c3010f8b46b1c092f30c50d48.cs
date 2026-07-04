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
using VampireSurvivors.Objects.Characters.Enemies;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_3252390c3010f8b46b1c092f30c50d48 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _3252390c3010f8b46b1c092f30c50d48_03ecdad5cca64933af1ea3bd7a0d2f30_CommandTarget;

		private Enemy_TP_GateBoss _3252390c3010f8b46b1c092f30c50d48_aaff7bc6988743dc89be5f05099cd620_CommandTarget;

		private Enemy_TP_GateBoss _3252390c3010f8b46b1c092f30c50d48_d27ed32261fc4dc48b6c3afeef0307b2_CommandTarget;

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

		private void BakeCommandBinding__3252390c3010f8b46b1c092f30c50d48_03ecdad5cca64933af1ea3bd7a0d2f30(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3252390c3010f8b46b1c092f30c50d48_03ecdad5cca64933af1ea3bd7a0d2f30(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3252390c3010f8b46b1c092f30c50d48_03ecdad5cca64933af1ea3bd7a0d2f30(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3252390c3010f8b46b1c092f30c50d48_03ecdad5cca64933af1ea3bd7a0d2f30(_3252390c3010f8b46b1c092f30c50d48_03ecdad5cca64933af1ea3bd7a0d2f30 command)
		{
		}

		private void BakeCommandBinding__3252390c3010f8b46b1c092f30c50d48_aaff7bc6988743dc89be5f05099cd620(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3252390c3010f8b46b1c092f30c50d48_aaff7bc6988743dc89be5f05099cd620(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3252390c3010f8b46b1c092f30c50d48_aaff7bc6988743dc89be5f05099cd620(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3252390c3010f8b46b1c092f30c50d48_aaff7bc6988743dc89be5f05099cd620(_3252390c3010f8b46b1c092f30c50d48_aaff7bc6988743dc89be5f05099cd620 command)
		{
		}

		private void BakeCommandBinding__3252390c3010f8b46b1c092f30c50d48_d27ed32261fc4dc48b6c3afeef0307b2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3252390c3010f8b46b1c092f30c50d48_d27ed32261fc4dc48b6c3afeef0307b2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3252390c3010f8b46b1c092f30c50d48_d27ed32261fc4dc48b6c3afeef0307b2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3252390c3010f8b46b1c092f30c50d48_d27ed32261fc4dc48b6c3afeef0307b2(_3252390c3010f8b46b1c092f30c50d48_d27ed32261fc4dc48b6c3afeef0307b2 command)
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
