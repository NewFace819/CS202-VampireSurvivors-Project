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
	public class CoherenceSync_f72cbcfeabeed0d48bb2f64bd7b1ef86 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _f72cbcfeabeed0d48bb2f64bd7b1ef86_77cd51ba08b940eebc60d193fb4c7bd2_CommandTarget;

		private EnemyTheEnder _f72cbcfeabeed0d48bb2f64bd7b1ef86_ffc5b8dd38144deabf62977206900c28_CommandTarget;

		private EnemyTheEnder _f72cbcfeabeed0d48bb2f64bd7b1ef86_565a035d95364bd682fd369084ee7e76_CommandTarget;

		private EnemyTheEnder _f72cbcfeabeed0d48bb2f64bd7b1ef86_38a544153b594f92812e26d8a0b4315f_CommandTarget;

		private EnemyTheEnder _f72cbcfeabeed0d48bb2f64bd7b1ef86_05e703e992274605811271e7694d0d50_CommandTarget;

		private EnemyTheEnder _f72cbcfeabeed0d48bb2f64bd7b1ef86_a6b15a76c9994bd0b9b964dfe6911a1c_CommandTarget;

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

		private void BakeCommandBinding__f72cbcfeabeed0d48bb2f64bd7b1ef86_77cd51ba08b940eebc60d193fb4c7bd2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_77cd51ba08b940eebc60d193fb4c7bd2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_77cd51ba08b940eebc60d193fb4c7bd2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_77cd51ba08b940eebc60d193fb4c7bd2(_f72cbcfeabeed0d48bb2f64bd7b1ef86_77cd51ba08b940eebc60d193fb4c7bd2 command)
		{
		}

		private void BakeCommandBinding__f72cbcfeabeed0d48bb2f64bd7b1ef86_ffc5b8dd38144deabf62977206900c28(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_ffc5b8dd38144deabf62977206900c28(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_ffc5b8dd38144deabf62977206900c28(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_ffc5b8dd38144deabf62977206900c28(_f72cbcfeabeed0d48bb2f64bd7b1ef86_ffc5b8dd38144deabf62977206900c28 command)
		{
		}

		private void BakeCommandBinding__f72cbcfeabeed0d48bb2f64bd7b1ef86_565a035d95364bd682fd369084ee7e76(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_565a035d95364bd682fd369084ee7e76(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_565a035d95364bd682fd369084ee7e76(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_565a035d95364bd682fd369084ee7e76(_f72cbcfeabeed0d48bb2f64bd7b1ef86_565a035d95364bd682fd369084ee7e76 command)
		{
		}

		private void BakeCommandBinding__f72cbcfeabeed0d48bb2f64bd7b1ef86_38a544153b594f92812e26d8a0b4315f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_38a544153b594f92812e26d8a0b4315f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_38a544153b594f92812e26d8a0b4315f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_38a544153b594f92812e26d8a0b4315f(_f72cbcfeabeed0d48bb2f64bd7b1ef86_38a544153b594f92812e26d8a0b4315f command)
		{
		}

		private void BakeCommandBinding__f72cbcfeabeed0d48bb2f64bd7b1ef86_05e703e992274605811271e7694d0d50(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_05e703e992274605811271e7694d0d50(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_05e703e992274605811271e7694d0d50(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_05e703e992274605811271e7694d0d50(_f72cbcfeabeed0d48bb2f64bd7b1ef86_05e703e992274605811271e7694d0d50 command)
		{
		}

		private void BakeCommandBinding__f72cbcfeabeed0d48bb2f64bd7b1ef86_a6b15a76c9994bd0b9b964dfe6911a1c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_a6b15a76c9994bd0b9b964dfe6911a1c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_a6b15a76c9994bd0b9b964dfe6911a1c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f72cbcfeabeed0d48bb2f64bd7b1ef86_a6b15a76c9994bd0b9b964dfe6911a1c(_f72cbcfeabeed0d48bb2f64bd7b1ef86_a6b15a76c9994bd0b9b964dfe6911a1c command)
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
