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
	public class CoherenceSync_7415a3957d9a5624b86fba36b08dbae6 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _7415a3957d9a5624b86fba36b08dbae6_1cb5649de2904bbb8d21d134ba954c6f_CommandTarget;

		private Enemy_TP_GateBoss _7415a3957d9a5624b86fba36b08dbae6_7b4d2d4331fd4f8c85a2ac7ae04e4681_CommandTarget;

		private Enemy_TP_GateBoss _7415a3957d9a5624b86fba36b08dbae6_03a6eb3622284b3abc5542635f1d7905_CommandTarget;

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

		private void BakeCommandBinding__7415a3957d9a5624b86fba36b08dbae6_1cb5649de2904bbb8d21d134ba954c6f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7415a3957d9a5624b86fba36b08dbae6_1cb5649de2904bbb8d21d134ba954c6f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7415a3957d9a5624b86fba36b08dbae6_1cb5649de2904bbb8d21d134ba954c6f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7415a3957d9a5624b86fba36b08dbae6_1cb5649de2904bbb8d21d134ba954c6f(_7415a3957d9a5624b86fba36b08dbae6_1cb5649de2904bbb8d21d134ba954c6f command)
		{
		}

		private void BakeCommandBinding__7415a3957d9a5624b86fba36b08dbae6_7b4d2d4331fd4f8c85a2ac7ae04e4681(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7415a3957d9a5624b86fba36b08dbae6_7b4d2d4331fd4f8c85a2ac7ae04e4681(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7415a3957d9a5624b86fba36b08dbae6_7b4d2d4331fd4f8c85a2ac7ae04e4681(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7415a3957d9a5624b86fba36b08dbae6_7b4d2d4331fd4f8c85a2ac7ae04e4681(_7415a3957d9a5624b86fba36b08dbae6_7b4d2d4331fd4f8c85a2ac7ae04e4681 command)
		{
		}

		private void BakeCommandBinding__7415a3957d9a5624b86fba36b08dbae6_03a6eb3622284b3abc5542635f1d7905(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7415a3957d9a5624b86fba36b08dbae6_03a6eb3622284b3abc5542635f1d7905(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7415a3957d9a5624b86fba36b08dbae6_03a6eb3622284b3abc5542635f1d7905(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7415a3957d9a5624b86fba36b08dbae6_03a6eb3622284b3abc5542635f1d7905(_7415a3957d9a5624b86fba36b08dbae6_03a6eb3622284b3abc5542635f1d7905 command)
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
