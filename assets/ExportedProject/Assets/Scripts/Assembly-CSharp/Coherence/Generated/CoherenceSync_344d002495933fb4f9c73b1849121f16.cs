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
	public class CoherenceSync_344d002495933fb4f9c73b1849121f16 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _344d002495933fb4f9c73b1849121f16_0c3335171f68438dbb2935300d74bef3_CommandTarget;

		private Enemy_TP_GateBoss _344d002495933fb4f9c73b1849121f16_4ab934e442874551a71d499049af5f20_CommandTarget;

		private Enemy_TP_GateBoss _344d002495933fb4f9c73b1849121f16_f4c70f7e9efb405da7bbf91d037125ee_CommandTarget;

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

		private void BakeCommandBinding__344d002495933fb4f9c73b1849121f16_0c3335171f68438dbb2935300d74bef3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__344d002495933fb4f9c73b1849121f16_0c3335171f68438dbb2935300d74bef3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__344d002495933fb4f9c73b1849121f16_0c3335171f68438dbb2935300d74bef3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__344d002495933fb4f9c73b1849121f16_0c3335171f68438dbb2935300d74bef3(_344d002495933fb4f9c73b1849121f16_0c3335171f68438dbb2935300d74bef3 command)
		{
		}

		private void BakeCommandBinding__344d002495933fb4f9c73b1849121f16_4ab934e442874551a71d499049af5f20(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__344d002495933fb4f9c73b1849121f16_4ab934e442874551a71d499049af5f20(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__344d002495933fb4f9c73b1849121f16_4ab934e442874551a71d499049af5f20(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__344d002495933fb4f9c73b1849121f16_4ab934e442874551a71d499049af5f20(_344d002495933fb4f9c73b1849121f16_4ab934e442874551a71d499049af5f20 command)
		{
		}

		private void BakeCommandBinding__344d002495933fb4f9c73b1849121f16_f4c70f7e9efb405da7bbf91d037125ee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__344d002495933fb4f9c73b1849121f16_f4c70f7e9efb405da7bbf91d037125ee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__344d002495933fb4f9c73b1849121f16_f4c70f7e9efb405da7bbf91d037125ee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__344d002495933fb4f9c73b1849121f16_f4c70f7e9efb405da7bbf91d037125ee(_344d002495933fb4f9c73b1849121f16_f4c70f7e9efb405da7bbf91d037125ee command)
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
