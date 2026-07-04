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
	public class CoherenceSync_ef2214f8cc656a241ba83becae6a65f4 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _ef2214f8cc656a241ba83becae6a65f4_1f31fecead5549a88b9db83cc6176596_CommandTarget;

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

		private void BakeCommandBinding__ef2214f8cc656a241ba83becae6a65f4_1f31fecead5549a88b9db83cc6176596(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef2214f8cc656a241ba83becae6a65f4_1f31fecead5549a88b9db83cc6176596(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef2214f8cc656a241ba83becae6a65f4_1f31fecead5549a88b9db83cc6176596(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef2214f8cc656a241ba83becae6a65f4_1f31fecead5549a88b9db83cc6176596(_ef2214f8cc656a241ba83becae6a65f4_1f31fecead5549a88b9db83cc6176596 command)
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
