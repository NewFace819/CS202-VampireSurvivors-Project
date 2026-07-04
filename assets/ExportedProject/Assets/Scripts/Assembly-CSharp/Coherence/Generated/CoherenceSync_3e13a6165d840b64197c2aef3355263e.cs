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
	public class CoherenceSync_3e13a6165d840b64197c2aef3355263e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_f3ab9b73fde24706a2a7c7218c57788e_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_2a4f23a6cc6c4024854ca4636c3efa7b_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_7285c149c95a463999abe7bdc9500491_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_68fd91788b254691aee90a775c6fdb28_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_88e195dfbe0e410d89b304bbf6288aee_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_c3b3c1b254694195ae77a2d304ba9884_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_4ec4b1235183429dbaee3520d4ac4aaa_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_7fc353facb8e4feb943315791e4fe135_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_062f7163d4d04a579ebbf0295d09abc0_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_82f3cd7aa5c2460b92d15f1b1a2c8388_CommandTarget;

		private TP_Olrox_Character _3e13a6165d840b64197c2aef3355263e_b648db63d66a498aa5c4a147bbe36a90_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_0d4f295c76e2443bbac679bc56047c6c_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_a0c0821abfcd448fa3929e0aca3400b9_CommandTarget;

		private CharacterController _3e13a6165d840b64197c2aef3355263e_bfbb3a4b59b04ee284596f1632862c6d_CommandTarget;

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

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_f3ab9b73fde24706a2a7c7218c57788e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_f3ab9b73fde24706a2a7c7218c57788e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_f3ab9b73fde24706a2a7c7218c57788e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_f3ab9b73fde24706a2a7c7218c57788e(_3e13a6165d840b64197c2aef3355263e_f3ab9b73fde24706a2a7c7218c57788e command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_2a4f23a6cc6c4024854ca4636c3efa7b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_2a4f23a6cc6c4024854ca4636c3efa7b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_2a4f23a6cc6c4024854ca4636c3efa7b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_2a4f23a6cc6c4024854ca4636c3efa7b(_3e13a6165d840b64197c2aef3355263e_2a4f23a6cc6c4024854ca4636c3efa7b command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_7285c149c95a463999abe7bdc9500491(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_7285c149c95a463999abe7bdc9500491(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_7285c149c95a463999abe7bdc9500491(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_7285c149c95a463999abe7bdc9500491(_3e13a6165d840b64197c2aef3355263e_7285c149c95a463999abe7bdc9500491 command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_68fd91788b254691aee90a775c6fdb28(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_68fd91788b254691aee90a775c6fdb28(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_68fd91788b254691aee90a775c6fdb28(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_68fd91788b254691aee90a775c6fdb28(_3e13a6165d840b64197c2aef3355263e_68fd91788b254691aee90a775c6fdb28 command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_88e195dfbe0e410d89b304bbf6288aee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_88e195dfbe0e410d89b304bbf6288aee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_88e195dfbe0e410d89b304bbf6288aee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_88e195dfbe0e410d89b304bbf6288aee(_3e13a6165d840b64197c2aef3355263e_88e195dfbe0e410d89b304bbf6288aee command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_c3b3c1b254694195ae77a2d304ba9884(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_c3b3c1b254694195ae77a2d304ba9884(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_c3b3c1b254694195ae77a2d304ba9884(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_c3b3c1b254694195ae77a2d304ba9884(_3e13a6165d840b64197c2aef3355263e_c3b3c1b254694195ae77a2d304ba9884 command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_4ec4b1235183429dbaee3520d4ac4aaa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_4ec4b1235183429dbaee3520d4ac4aaa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_4ec4b1235183429dbaee3520d4ac4aaa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_4ec4b1235183429dbaee3520d4ac4aaa(_3e13a6165d840b64197c2aef3355263e_4ec4b1235183429dbaee3520d4ac4aaa command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_7fc353facb8e4feb943315791e4fe135(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_7fc353facb8e4feb943315791e4fe135(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_7fc353facb8e4feb943315791e4fe135(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_7fc353facb8e4feb943315791e4fe135(_3e13a6165d840b64197c2aef3355263e_7fc353facb8e4feb943315791e4fe135 command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_062f7163d4d04a579ebbf0295d09abc0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_062f7163d4d04a579ebbf0295d09abc0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_062f7163d4d04a579ebbf0295d09abc0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_062f7163d4d04a579ebbf0295d09abc0(_3e13a6165d840b64197c2aef3355263e_062f7163d4d04a579ebbf0295d09abc0 command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_82f3cd7aa5c2460b92d15f1b1a2c8388(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_82f3cd7aa5c2460b92d15f1b1a2c8388(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_82f3cd7aa5c2460b92d15f1b1a2c8388(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_82f3cd7aa5c2460b92d15f1b1a2c8388(_3e13a6165d840b64197c2aef3355263e_82f3cd7aa5c2460b92d15f1b1a2c8388 command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_b648db63d66a498aa5c4a147bbe36a90(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_b648db63d66a498aa5c4a147bbe36a90(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_b648db63d66a498aa5c4a147bbe36a90(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_b648db63d66a498aa5c4a147bbe36a90(_3e13a6165d840b64197c2aef3355263e_b648db63d66a498aa5c4a147bbe36a90 command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_0d4f295c76e2443bbac679bc56047c6c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_0d4f295c76e2443bbac679bc56047c6c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_0d4f295c76e2443bbac679bc56047c6c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_0d4f295c76e2443bbac679bc56047c6c(_3e13a6165d840b64197c2aef3355263e_0d4f295c76e2443bbac679bc56047c6c command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_a0c0821abfcd448fa3929e0aca3400b9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_a0c0821abfcd448fa3929e0aca3400b9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_a0c0821abfcd448fa3929e0aca3400b9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_a0c0821abfcd448fa3929e0aca3400b9(_3e13a6165d840b64197c2aef3355263e_a0c0821abfcd448fa3929e0aca3400b9 command)
		{
		}

		private void BakeCommandBinding__3e13a6165d840b64197c2aef3355263e_bfbb3a4b59b04ee284596f1632862c6d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3e13a6165d840b64197c2aef3355263e_bfbb3a4b59b04ee284596f1632862c6d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3e13a6165d840b64197c2aef3355263e_bfbb3a4b59b04ee284596f1632862c6d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3e13a6165d840b64197c2aef3355263e_bfbb3a4b59b04ee284596f1632862c6d(_3e13a6165d840b64197c2aef3355263e_bfbb3a4b59b04ee284596f1632862c6d command)
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
