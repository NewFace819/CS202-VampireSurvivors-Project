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
	public class CoherenceSync_c65bec662c536e14a8859a6587d04e24 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _c65bec662c536e14a8859a6587d04e24_31deeaf0cead41fea9db42d67e2f2938_CommandTarget;

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

		private void BakeCommandBinding__c65bec662c536e14a8859a6587d04e24_31deeaf0cead41fea9db42d67e2f2938(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c65bec662c536e14a8859a6587d04e24_31deeaf0cead41fea9db42d67e2f2938(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c65bec662c536e14a8859a6587d04e24_31deeaf0cead41fea9db42d67e2f2938(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c65bec662c536e14a8859a6587d04e24_31deeaf0cead41fea9db42d67e2f2938(_c65bec662c536e14a8859a6587d04e24_31deeaf0cead41fea9db42d67e2f2938 command)
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
