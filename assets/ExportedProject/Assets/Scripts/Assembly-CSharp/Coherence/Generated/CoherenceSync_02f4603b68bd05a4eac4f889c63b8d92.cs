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
	public class CoherenceSync_02f4603b68bd05a4eac4f889c63b8d92 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _02f4603b68bd05a4eac4f889c63b8d92_742e3008953c4b36930ac1016e2c15f2_CommandTarget;

		private Enemy_TP_GateBoss _02f4603b68bd05a4eac4f889c63b8d92_a584dde2ed264299b949a2078fa2ef63_CommandTarget;

		private Enemy_TP_GateBoss _02f4603b68bd05a4eac4f889c63b8d92_e2498dbedb814eceaa27fada31b9a49c_CommandTarget;

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

		private void BakeCommandBinding__02f4603b68bd05a4eac4f889c63b8d92_742e3008953c4b36930ac1016e2c15f2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__02f4603b68bd05a4eac4f889c63b8d92_742e3008953c4b36930ac1016e2c15f2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__02f4603b68bd05a4eac4f889c63b8d92_742e3008953c4b36930ac1016e2c15f2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__02f4603b68bd05a4eac4f889c63b8d92_742e3008953c4b36930ac1016e2c15f2(_02f4603b68bd05a4eac4f889c63b8d92_742e3008953c4b36930ac1016e2c15f2 command)
		{
		}

		private void BakeCommandBinding__02f4603b68bd05a4eac4f889c63b8d92_a584dde2ed264299b949a2078fa2ef63(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__02f4603b68bd05a4eac4f889c63b8d92_a584dde2ed264299b949a2078fa2ef63(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__02f4603b68bd05a4eac4f889c63b8d92_a584dde2ed264299b949a2078fa2ef63(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__02f4603b68bd05a4eac4f889c63b8d92_a584dde2ed264299b949a2078fa2ef63(_02f4603b68bd05a4eac4f889c63b8d92_a584dde2ed264299b949a2078fa2ef63 command)
		{
		}

		private void BakeCommandBinding__02f4603b68bd05a4eac4f889c63b8d92_e2498dbedb814eceaa27fada31b9a49c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__02f4603b68bd05a4eac4f889c63b8d92_e2498dbedb814eceaa27fada31b9a49c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__02f4603b68bd05a4eac4f889c63b8d92_e2498dbedb814eceaa27fada31b9a49c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__02f4603b68bd05a4eac4f889c63b8d92_e2498dbedb814eceaa27fada31b9a49c(_02f4603b68bd05a4eac4f889c63b8d92_e2498dbedb814eceaa27fada31b9a49c command)
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
