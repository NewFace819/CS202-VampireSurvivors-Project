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
	public class CoherenceSync_32077016b3d740f438be7293b01c02ac : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _32077016b3d740f438be7293b01c02ac_1ac21abe2def4ba29565ef18243ff69d_CommandTarget;

		private EnemyDirecter _32077016b3d740f438be7293b01c02ac_0b73493f9a2f4f69a52927cd0c75fae5_CommandTarget;

		private EnemyDirecter _32077016b3d740f438be7293b01c02ac_3287adf06700405998b593aba3e7edfc_CommandTarget;

		private EnemyDirecter _32077016b3d740f438be7293b01c02ac_558258a651ec447bab8f230df7e45fd5_CommandTarget;

		private EnemyDirecter _32077016b3d740f438be7293b01c02ac_1b9644bd635e4852b4cdcd0146b89784_CommandTarget;

		private EnemyDirecter _32077016b3d740f438be7293b01c02ac_cb115c533bcf4b699b3782712f463ef5_CommandTarget;

		private EnemyDirecter _32077016b3d740f438be7293b01c02ac_1a3bd1a8470c49508f0b0a775836b804_CommandTarget;

		private EnemyDirecter _32077016b3d740f438be7293b01c02ac_d21b06b47b48437c9db6ab57d8a92581_CommandTarget;

		private EnemyDirecter _32077016b3d740f438be7293b01c02ac_6b40ce9205ae45ac98c2b4126090df17_CommandTarget;

		private EnemyDirecter _32077016b3d740f438be7293b01c02ac_cf40abe7dc5f4882a8a22fb75de9ed16_CommandTarget;

		private EnemyDirecter _32077016b3d740f438be7293b01c02ac_e20571c2e1e747d4bffd549aacd96db0_CommandTarget;

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

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_1ac21abe2def4ba29565ef18243ff69d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_1ac21abe2def4ba29565ef18243ff69d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_1ac21abe2def4ba29565ef18243ff69d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_1ac21abe2def4ba29565ef18243ff69d(_32077016b3d740f438be7293b01c02ac_1ac21abe2def4ba29565ef18243ff69d command)
		{
		}

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_0b73493f9a2f4f69a52927cd0c75fae5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_0b73493f9a2f4f69a52927cd0c75fae5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_0b73493f9a2f4f69a52927cd0c75fae5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_0b73493f9a2f4f69a52927cd0c75fae5(_32077016b3d740f438be7293b01c02ac_0b73493f9a2f4f69a52927cd0c75fae5 command)
		{
		}

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_3287adf06700405998b593aba3e7edfc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_3287adf06700405998b593aba3e7edfc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_3287adf06700405998b593aba3e7edfc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_3287adf06700405998b593aba3e7edfc(_32077016b3d740f438be7293b01c02ac_3287adf06700405998b593aba3e7edfc command)
		{
		}

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_558258a651ec447bab8f230df7e45fd5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_558258a651ec447bab8f230df7e45fd5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_558258a651ec447bab8f230df7e45fd5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_558258a651ec447bab8f230df7e45fd5(_32077016b3d740f438be7293b01c02ac_558258a651ec447bab8f230df7e45fd5 command)
		{
		}

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_1b9644bd635e4852b4cdcd0146b89784(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_1b9644bd635e4852b4cdcd0146b89784(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_1b9644bd635e4852b4cdcd0146b89784(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_1b9644bd635e4852b4cdcd0146b89784(_32077016b3d740f438be7293b01c02ac_1b9644bd635e4852b4cdcd0146b89784 command)
		{
		}

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_cb115c533bcf4b699b3782712f463ef5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_cb115c533bcf4b699b3782712f463ef5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_cb115c533bcf4b699b3782712f463ef5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_cb115c533bcf4b699b3782712f463ef5(_32077016b3d740f438be7293b01c02ac_cb115c533bcf4b699b3782712f463ef5 command)
		{
		}

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_1a3bd1a8470c49508f0b0a775836b804(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_1a3bd1a8470c49508f0b0a775836b804(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_1a3bd1a8470c49508f0b0a775836b804(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_1a3bd1a8470c49508f0b0a775836b804(_32077016b3d740f438be7293b01c02ac_1a3bd1a8470c49508f0b0a775836b804 command)
		{
		}

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_d21b06b47b48437c9db6ab57d8a92581(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_d21b06b47b48437c9db6ab57d8a92581(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_d21b06b47b48437c9db6ab57d8a92581(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_d21b06b47b48437c9db6ab57d8a92581(_32077016b3d740f438be7293b01c02ac_d21b06b47b48437c9db6ab57d8a92581 command)
		{
		}

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_6b40ce9205ae45ac98c2b4126090df17(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_6b40ce9205ae45ac98c2b4126090df17(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_6b40ce9205ae45ac98c2b4126090df17(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_6b40ce9205ae45ac98c2b4126090df17(_32077016b3d740f438be7293b01c02ac_6b40ce9205ae45ac98c2b4126090df17 command)
		{
		}

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_cf40abe7dc5f4882a8a22fb75de9ed16(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_cf40abe7dc5f4882a8a22fb75de9ed16(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_cf40abe7dc5f4882a8a22fb75de9ed16(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_cf40abe7dc5f4882a8a22fb75de9ed16(_32077016b3d740f438be7293b01c02ac_cf40abe7dc5f4882a8a22fb75de9ed16 command)
		{
		}

		private void BakeCommandBinding__32077016b3d740f438be7293b01c02ac_e20571c2e1e747d4bffd549aacd96db0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__32077016b3d740f438be7293b01c02ac_e20571c2e1e747d4bffd549aacd96db0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__32077016b3d740f438be7293b01c02ac_e20571c2e1e747d4bffd549aacd96db0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__32077016b3d740f438be7293b01c02ac_e20571c2e1e747d4bffd549aacd96db0(_32077016b3d740f438be7293b01c02ac_e20571c2e1e747d4bffd549aacd96db0 command)
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
