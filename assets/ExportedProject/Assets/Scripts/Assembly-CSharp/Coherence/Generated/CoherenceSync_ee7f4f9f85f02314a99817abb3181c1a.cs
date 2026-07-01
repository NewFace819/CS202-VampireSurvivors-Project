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
	public class CoherenceSync_ee7f4f9f85f02314a99817abb3181c1a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _ee7f4f9f85f02314a99817abb3181c1a_72519f159ff54aeab9ff4a46446969bf_CommandTarget;

		private Enemy_TP_GateBoss _ee7f4f9f85f02314a99817abb3181c1a_34e91c383e024b2887c2a39ad8ec8c10_CommandTarget;

		private Enemy_TP_GateBoss _ee7f4f9f85f02314a99817abb3181c1a_6fad9165358044c68904e483609ca91a_CommandTarget;

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

		private void BakeCommandBinding__ee7f4f9f85f02314a99817abb3181c1a_72519f159ff54aeab9ff4a46446969bf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ee7f4f9f85f02314a99817abb3181c1a_72519f159ff54aeab9ff4a46446969bf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ee7f4f9f85f02314a99817abb3181c1a_72519f159ff54aeab9ff4a46446969bf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ee7f4f9f85f02314a99817abb3181c1a_72519f159ff54aeab9ff4a46446969bf(_ee7f4f9f85f02314a99817abb3181c1a_72519f159ff54aeab9ff4a46446969bf command)
		{
		}

		private void BakeCommandBinding__ee7f4f9f85f02314a99817abb3181c1a_34e91c383e024b2887c2a39ad8ec8c10(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ee7f4f9f85f02314a99817abb3181c1a_34e91c383e024b2887c2a39ad8ec8c10(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ee7f4f9f85f02314a99817abb3181c1a_34e91c383e024b2887c2a39ad8ec8c10(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ee7f4f9f85f02314a99817abb3181c1a_34e91c383e024b2887c2a39ad8ec8c10(_ee7f4f9f85f02314a99817abb3181c1a_34e91c383e024b2887c2a39ad8ec8c10 command)
		{
		}

		private void BakeCommandBinding__ee7f4f9f85f02314a99817abb3181c1a_6fad9165358044c68904e483609ca91a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ee7f4f9f85f02314a99817abb3181c1a_6fad9165358044c68904e483609ca91a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ee7f4f9f85f02314a99817abb3181c1a_6fad9165358044c68904e483609ca91a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ee7f4f9f85f02314a99817abb3181c1a_6fad9165358044c68904e483609ca91a(_ee7f4f9f85f02314a99817abb3181c1a_6fad9165358044c68904e483609ca91a command)
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
