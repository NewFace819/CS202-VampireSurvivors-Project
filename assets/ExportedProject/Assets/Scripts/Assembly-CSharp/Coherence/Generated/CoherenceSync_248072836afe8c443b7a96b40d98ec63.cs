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
	public class CoherenceSync_248072836afe8c443b7a96b40d98ec63 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _248072836afe8c443b7a96b40d98ec63_dcfc9cff697b4fd780cebcbfeb8d0d33_CommandTarget;

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

		private void BakeCommandBinding__248072836afe8c443b7a96b40d98ec63_dcfc9cff697b4fd780cebcbfeb8d0d33(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__248072836afe8c443b7a96b40d98ec63_dcfc9cff697b4fd780cebcbfeb8d0d33(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__248072836afe8c443b7a96b40d98ec63_dcfc9cff697b4fd780cebcbfeb8d0d33(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__248072836afe8c443b7a96b40d98ec63_dcfc9cff697b4fd780cebcbfeb8d0d33(_248072836afe8c443b7a96b40d98ec63_dcfc9cff697b4fd780cebcbfeb8d0d33 command)
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
