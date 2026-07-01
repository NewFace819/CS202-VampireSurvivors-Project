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
	public class CoherenceSync_f5f539957d242894594aedc0b107db40 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _f5f539957d242894594aedc0b107db40_14312a5668ea4e56bcd19526c38eb35d_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_956a4cab02434773b80943821a7c059f_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_317ff47fa295420a973d78666ed150c2_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_4030d3df53244d74a56413aa5a6e0155_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_7f6d4d33e7a3430c89d2ac882edc7da4_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_81dc5dae18ee4dcea2ea70ee8660094e_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_f9d60afe83414b2392fd79817048e7f4_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_01b86c613b50491aa6d47e728b6f85e5_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_55725cbe5ba443248f9230d258f39b2c_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_7cfabf7f8be44961aa026a7c7ae2be4b_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_93da7122830446feb79e1c720028dfe9_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_7366ff2f6a284ef99d254800d4db7a1d_CommandTarget;

		private CharacterController _f5f539957d242894594aedc0b107db40_6e95fbc63b04407ea32048710e82bc04_CommandTarget;

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

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_14312a5668ea4e56bcd19526c38eb35d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_14312a5668ea4e56bcd19526c38eb35d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_14312a5668ea4e56bcd19526c38eb35d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_14312a5668ea4e56bcd19526c38eb35d(_f5f539957d242894594aedc0b107db40_14312a5668ea4e56bcd19526c38eb35d command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_956a4cab02434773b80943821a7c059f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_956a4cab02434773b80943821a7c059f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_956a4cab02434773b80943821a7c059f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_956a4cab02434773b80943821a7c059f(_f5f539957d242894594aedc0b107db40_956a4cab02434773b80943821a7c059f command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_317ff47fa295420a973d78666ed150c2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_317ff47fa295420a973d78666ed150c2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_317ff47fa295420a973d78666ed150c2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_317ff47fa295420a973d78666ed150c2(_f5f539957d242894594aedc0b107db40_317ff47fa295420a973d78666ed150c2 command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_4030d3df53244d74a56413aa5a6e0155(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_4030d3df53244d74a56413aa5a6e0155(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_4030d3df53244d74a56413aa5a6e0155(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_4030d3df53244d74a56413aa5a6e0155(_f5f539957d242894594aedc0b107db40_4030d3df53244d74a56413aa5a6e0155 command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_7f6d4d33e7a3430c89d2ac882edc7da4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_7f6d4d33e7a3430c89d2ac882edc7da4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_7f6d4d33e7a3430c89d2ac882edc7da4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_7f6d4d33e7a3430c89d2ac882edc7da4(_f5f539957d242894594aedc0b107db40_7f6d4d33e7a3430c89d2ac882edc7da4 command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_81dc5dae18ee4dcea2ea70ee8660094e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_81dc5dae18ee4dcea2ea70ee8660094e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_81dc5dae18ee4dcea2ea70ee8660094e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_81dc5dae18ee4dcea2ea70ee8660094e(_f5f539957d242894594aedc0b107db40_81dc5dae18ee4dcea2ea70ee8660094e command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_f9d60afe83414b2392fd79817048e7f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_f9d60afe83414b2392fd79817048e7f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_f9d60afe83414b2392fd79817048e7f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_f9d60afe83414b2392fd79817048e7f4(_f5f539957d242894594aedc0b107db40_f9d60afe83414b2392fd79817048e7f4 command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_01b86c613b50491aa6d47e728b6f85e5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_01b86c613b50491aa6d47e728b6f85e5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_01b86c613b50491aa6d47e728b6f85e5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_01b86c613b50491aa6d47e728b6f85e5(_f5f539957d242894594aedc0b107db40_01b86c613b50491aa6d47e728b6f85e5 command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_55725cbe5ba443248f9230d258f39b2c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_55725cbe5ba443248f9230d258f39b2c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_55725cbe5ba443248f9230d258f39b2c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_55725cbe5ba443248f9230d258f39b2c(_f5f539957d242894594aedc0b107db40_55725cbe5ba443248f9230d258f39b2c command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_7cfabf7f8be44961aa026a7c7ae2be4b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_7cfabf7f8be44961aa026a7c7ae2be4b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_7cfabf7f8be44961aa026a7c7ae2be4b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_7cfabf7f8be44961aa026a7c7ae2be4b(_f5f539957d242894594aedc0b107db40_7cfabf7f8be44961aa026a7c7ae2be4b command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_93da7122830446feb79e1c720028dfe9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_93da7122830446feb79e1c720028dfe9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_93da7122830446feb79e1c720028dfe9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_93da7122830446feb79e1c720028dfe9(_f5f539957d242894594aedc0b107db40_93da7122830446feb79e1c720028dfe9 command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_7366ff2f6a284ef99d254800d4db7a1d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_7366ff2f6a284ef99d254800d4db7a1d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_7366ff2f6a284ef99d254800d4db7a1d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_7366ff2f6a284ef99d254800d4db7a1d(_f5f539957d242894594aedc0b107db40_7366ff2f6a284ef99d254800d4db7a1d command)
		{
		}

		private void BakeCommandBinding__f5f539957d242894594aedc0b107db40_6e95fbc63b04407ea32048710e82bc04(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5f539957d242894594aedc0b107db40_6e95fbc63b04407ea32048710e82bc04(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5f539957d242894594aedc0b107db40_6e95fbc63b04407ea32048710e82bc04(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5f539957d242894594aedc0b107db40_6e95fbc63b04407ea32048710e82bc04(_f5f539957d242894594aedc0b107db40_6e95fbc63b04407ea32048710e82bc04 command)
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
