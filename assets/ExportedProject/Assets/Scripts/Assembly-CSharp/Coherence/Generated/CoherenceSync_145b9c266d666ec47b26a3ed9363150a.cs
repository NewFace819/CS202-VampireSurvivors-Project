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
	public class CoherenceSync_145b9c266d666ec47b26a3ed9363150a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _145b9c266d666ec47b26a3ed9363150a_8e6308f608824297ac7e0f9771d5c619_CommandTarget;

		private NetworkPickup _145b9c266d666ec47b26a3ed9363150a_3064d7a06608492dbe498316cb69c76c_CommandTarget;

		private NetworkPickup _145b9c266d666ec47b26a3ed9363150a_016d4ae2d20347d3be16dbf0bd54e1cb_CommandTarget;

		private NetworkPickup _145b9c266d666ec47b26a3ed9363150a_b1097636717a4c6f857ae691e9273e42_CommandTarget;

		private NetworkPickup _145b9c266d666ec47b26a3ed9363150a_b34913cc625d48ad89814a2eca89df19_CommandTarget;

		private NetworkPickup _145b9c266d666ec47b26a3ed9363150a_3a9e2dc45bf141799d6ffe8ff153e40a_CommandTarget;

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

		private void BakeCommandBinding__145b9c266d666ec47b26a3ed9363150a_8e6308f608824297ac7e0f9771d5c619(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__145b9c266d666ec47b26a3ed9363150a_8e6308f608824297ac7e0f9771d5c619(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__145b9c266d666ec47b26a3ed9363150a_8e6308f608824297ac7e0f9771d5c619(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__145b9c266d666ec47b26a3ed9363150a_8e6308f608824297ac7e0f9771d5c619(_145b9c266d666ec47b26a3ed9363150a_8e6308f608824297ac7e0f9771d5c619 command)
		{
		}

		private void BakeCommandBinding__145b9c266d666ec47b26a3ed9363150a_3064d7a06608492dbe498316cb69c76c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__145b9c266d666ec47b26a3ed9363150a_3064d7a06608492dbe498316cb69c76c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__145b9c266d666ec47b26a3ed9363150a_3064d7a06608492dbe498316cb69c76c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__145b9c266d666ec47b26a3ed9363150a_3064d7a06608492dbe498316cb69c76c(_145b9c266d666ec47b26a3ed9363150a_3064d7a06608492dbe498316cb69c76c command)
		{
		}

		private void BakeCommandBinding__145b9c266d666ec47b26a3ed9363150a_016d4ae2d20347d3be16dbf0bd54e1cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__145b9c266d666ec47b26a3ed9363150a_016d4ae2d20347d3be16dbf0bd54e1cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__145b9c266d666ec47b26a3ed9363150a_016d4ae2d20347d3be16dbf0bd54e1cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__145b9c266d666ec47b26a3ed9363150a_016d4ae2d20347d3be16dbf0bd54e1cb(_145b9c266d666ec47b26a3ed9363150a_016d4ae2d20347d3be16dbf0bd54e1cb command)
		{
		}

		private void BakeCommandBinding__145b9c266d666ec47b26a3ed9363150a_b1097636717a4c6f857ae691e9273e42(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__145b9c266d666ec47b26a3ed9363150a_b1097636717a4c6f857ae691e9273e42(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__145b9c266d666ec47b26a3ed9363150a_b1097636717a4c6f857ae691e9273e42(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__145b9c266d666ec47b26a3ed9363150a_b1097636717a4c6f857ae691e9273e42(_145b9c266d666ec47b26a3ed9363150a_b1097636717a4c6f857ae691e9273e42 command)
		{
		}

		private void BakeCommandBinding__145b9c266d666ec47b26a3ed9363150a_b34913cc625d48ad89814a2eca89df19(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__145b9c266d666ec47b26a3ed9363150a_b34913cc625d48ad89814a2eca89df19(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__145b9c266d666ec47b26a3ed9363150a_b34913cc625d48ad89814a2eca89df19(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__145b9c266d666ec47b26a3ed9363150a_b34913cc625d48ad89814a2eca89df19(_145b9c266d666ec47b26a3ed9363150a_b34913cc625d48ad89814a2eca89df19 command)
		{
		}

		private void BakeCommandBinding__145b9c266d666ec47b26a3ed9363150a_3a9e2dc45bf141799d6ffe8ff153e40a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__145b9c266d666ec47b26a3ed9363150a_3a9e2dc45bf141799d6ffe8ff153e40a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__145b9c266d666ec47b26a3ed9363150a_3a9e2dc45bf141799d6ffe8ff153e40a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__145b9c266d666ec47b26a3ed9363150a_3a9e2dc45bf141799d6ffe8ff153e40a(_145b9c266d666ec47b26a3ed9363150a_3a9e2dc45bf141799d6ffe8ff153e40a command)
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
