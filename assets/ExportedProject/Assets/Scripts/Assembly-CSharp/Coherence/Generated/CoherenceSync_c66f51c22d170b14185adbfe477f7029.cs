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
	public class CoherenceSync_c66f51c22d170b14185adbfe477f7029 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _c66f51c22d170b14185adbfe477f7029_713b739087694484a5ce8b365930ef0f_CommandTarget;

		private Enemy_TP_GateBoss _c66f51c22d170b14185adbfe477f7029_ad840148c8934b9a91d237c2998aa272_CommandTarget;

		private Enemy_TP_GateBoss _c66f51c22d170b14185adbfe477f7029_93d003e0540c4885a6cf8abc2715459c_CommandTarget;

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

		private void BakeCommandBinding__c66f51c22d170b14185adbfe477f7029_713b739087694484a5ce8b365930ef0f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c66f51c22d170b14185adbfe477f7029_713b739087694484a5ce8b365930ef0f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c66f51c22d170b14185adbfe477f7029_713b739087694484a5ce8b365930ef0f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c66f51c22d170b14185adbfe477f7029_713b739087694484a5ce8b365930ef0f(_c66f51c22d170b14185adbfe477f7029_713b739087694484a5ce8b365930ef0f command)
		{
		}

		private void BakeCommandBinding__c66f51c22d170b14185adbfe477f7029_ad840148c8934b9a91d237c2998aa272(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c66f51c22d170b14185adbfe477f7029_ad840148c8934b9a91d237c2998aa272(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c66f51c22d170b14185adbfe477f7029_ad840148c8934b9a91d237c2998aa272(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c66f51c22d170b14185adbfe477f7029_ad840148c8934b9a91d237c2998aa272(_c66f51c22d170b14185adbfe477f7029_ad840148c8934b9a91d237c2998aa272 command)
		{
		}

		private void BakeCommandBinding__c66f51c22d170b14185adbfe477f7029_93d003e0540c4885a6cf8abc2715459c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c66f51c22d170b14185adbfe477f7029_93d003e0540c4885a6cf8abc2715459c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c66f51c22d170b14185adbfe477f7029_93d003e0540c4885a6cf8abc2715459c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c66f51c22d170b14185adbfe477f7029_93d003e0540c4885a6cf8abc2715459c(_c66f51c22d170b14185adbfe477f7029_93d003e0540c4885a6cf8abc2715459c command)
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
