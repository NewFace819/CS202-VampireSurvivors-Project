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
	public class CoherenceSync_95df818acc198ac4e9c737a2b8923eb8 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _95df818acc198ac4e9c737a2b8923eb8_43bbe7feca4f4f9ea5f60c1dc87f5adc_CommandTarget;

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

		private void BakeCommandBinding__95df818acc198ac4e9c737a2b8923eb8_43bbe7feca4f4f9ea5f60c1dc87f5adc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__95df818acc198ac4e9c737a2b8923eb8_43bbe7feca4f4f9ea5f60c1dc87f5adc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__95df818acc198ac4e9c737a2b8923eb8_43bbe7feca4f4f9ea5f60c1dc87f5adc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__95df818acc198ac4e9c737a2b8923eb8_43bbe7feca4f4f9ea5f60c1dc87f5adc(_95df818acc198ac4e9c737a2b8923eb8_43bbe7feca4f4f9ea5f60c1dc87f5adc command)
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
