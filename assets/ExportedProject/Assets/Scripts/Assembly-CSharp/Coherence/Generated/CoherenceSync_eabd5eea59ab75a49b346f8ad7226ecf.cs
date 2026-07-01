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
	public class CoherenceSync_eabd5eea59ab75a49b346f8ad7226ecf : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _eabd5eea59ab75a49b346f8ad7226ecf_f49f24e11a484343a3e75bf95ba5d6fd_CommandTarget;

		private Enemy_TP_GateBoss _eabd5eea59ab75a49b346f8ad7226ecf_0eacb231045244c2b7a00c4fdd868954_CommandTarget;

		private Enemy_TP_GateBoss _eabd5eea59ab75a49b346f8ad7226ecf_f692db3f8b9a4ab8a6d9b977c97593d5_CommandTarget;

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

		private void BakeCommandBinding__eabd5eea59ab75a49b346f8ad7226ecf_f49f24e11a484343a3e75bf95ba5d6fd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eabd5eea59ab75a49b346f8ad7226ecf_f49f24e11a484343a3e75bf95ba5d6fd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eabd5eea59ab75a49b346f8ad7226ecf_f49f24e11a484343a3e75bf95ba5d6fd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eabd5eea59ab75a49b346f8ad7226ecf_f49f24e11a484343a3e75bf95ba5d6fd(_eabd5eea59ab75a49b346f8ad7226ecf_f49f24e11a484343a3e75bf95ba5d6fd command)
		{
		}

		private void BakeCommandBinding__eabd5eea59ab75a49b346f8ad7226ecf_0eacb231045244c2b7a00c4fdd868954(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eabd5eea59ab75a49b346f8ad7226ecf_0eacb231045244c2b7a00c4fdd868954(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eabd5eea59ab75a49b346f8ad7226ecf_0eacb231045244c2b7a00c4fdd868954(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eabd5eea59ab75a49b346f8ad7226ecf_0eacb231045244c2b7a00c4fdd868954(_eabd5eea59ab75a49b346f8ad7226ecf_0eacb231045244c2b7a00c4fdd868954 command)
		{
		}

		private void BakeCommandBinding__eabd5eea59ab75a49b346f8ad7226ecf_f692db3f8b9a4ab8a6d9b977c97593d5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eabd5eea59ab75a49b346f8ad7226ecf_f692db3f8b9a4ab8a6d9b977c97593d5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eabd5eea59ab75a49b346f8ad7226ecf_f692db3f8b9a4ab8a6d9b977c97593d5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eabd5eea59ab75a49b346f8ad7226ecf_f692db3f8b9a4ab8a6d9b977c97593d5(_eabd5eea59ab75a49b346f8ad7226ecf_f692db3f8b9a4ab8a6d9b977c97593d5 command)
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
