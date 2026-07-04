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
	public class CoherenceSync_398ba3a349c82544ab73dce8ac0866a4 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_5cffedc390d5450cb4a1c494919cf0bf_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_eb9e13cf518544e8b29b73f8d2545a37_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_776ddc02a345484f9069df8021767af4_CommandTarget;

		private FB_Simondo _398ba3a349c82544ab73dce8ac0866a4_2004d0a08f65487ab5bf2e91cca89365_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_d25458a151ae4d119a720b81449a0751_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_d7a5ed5da3c2412b9512fe8b69bf773f_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_c669d00c6613410281deb04ad5451e94_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_7d96d5532d154cd99b0a3c34d2cb31fe_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_cf500fb10b664307bfd3c6af62739f6e_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_558bb418da4b4fdc83fe59eda98f7d0b_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_093fc1c4c1c549c79c6ee9f7707f713d_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_b6f63d37016645c497b888ac457cde13_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_e65f6679521e4b1c9cba9ae463c6a338_CommandTarget;

		private CharacterController _398ba3a349c82544ab73dce8ac0866a4_ac37c0fcfb7e42b9803faf23ed1628fa_CommandTarget;

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

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_5cffedc390d5450cb4a1c494919cf0bf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_5cffedc390d5450cb4a1c494919cf0bf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_5cffedc390d5450cb4a1c494919cf0bf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_5cffedc390d5450cb4a1c494919cf0bf(_398ba3a349c82544ab73dce8ac0866a4_5cffedc390d5450cb4a1c494919cf0bf command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_eb9e13cf518544e8b29b73f8d2545a37(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_eb9e13cf518544e8b29b73f8d2545a37(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_eb9e13cf518544e8b29b73f8d2545a37(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_eb9e13cf518544e8b29b73f8d2545a37(_398ba3a349c82544ab73dce8ac0866a4_eb9e13cf518544e8b29b73f8d2545a37 command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_776ddc02a345484f9069df8021767af4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_776ddc02a345484f9069df8021767af4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_776ddc02a345484f9069df8021767af4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_776ddc02a345484f9069df8021767af4(_398ba3a349c82544ab73dce8ac0866a4_776ddc02a345484f9069df8021767af4 command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_2004d0a08f65487ab5bf2e91cca89365(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_2004d0a08f65487ab5bf2e91cca89365(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_2004d0a08f65487ab5bf2e91cca89365(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_2004d0a08f65487ab5bf2e91cca89365(_398ba3a349c82544ab73dce8ac0866a4_2004d0a08f65487ab5bf2e91cca89365 command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_d25458a151ae4d119a720b81449a0751(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_d25458a151ae4d119a720b81449a0751(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_d25458a151ae4d119a720b81449a0751(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_d25458a151ae4d119a720b81449a0751(_398ba3a349c82544ab73dce8ac0866a4_d25458a151ae4d119a720b81449a0751 command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_d7a5ed5da3c2412b9512fe8b69bf773f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_d7a5ed5da3c2412b9512fe8b69bf773f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_d7a5ed5da3c2412b9512fe8b69bf773f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_d7a5ed5da3c2412b9512fe8b69bf773f(_398ba3a349c82544ab73dce8ac0866a4_d7a5ed5da3c2412b9512fe8b69bf773f command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_c669d00c6613410281deb04ad5451e94(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_c669d00c6613410281deb04ad5451e94(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_c669d00c6613410281deb04ad5451e94(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_c669d00c6613410281deb04ad5451e94(_398ba3a349c82544ab73dce8ac0866a4_c669d00c6613410281deb04ad5451e94 command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_7d96d5532d154cd99b0a3c34d2cb31fe(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_7d96d5532d154cd99b0a3c34d2cb31fe(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_7d96d5532d154cd99b0a3c34d2cb31fe(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_7d96d5532d154cd99b0a3c34d2cb31fe(_398ba3a349c82544ab73dce8ac0866a4_7d96d5532d154cd99b0a3c34d2cb31fe command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_cf500fb10b664307bfd3c6af62739f6e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_cf500fb10b664307bfd3c6af62739f6e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_cf500fb10b664307bfd3c6af62739f6e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_cf500fb10b664307bfd3c6af62739f6e(_398ba3a349c82544ab73dce8ac0866a4_cf500fb10b664307bfd3c6af62739f6e command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_558bb418da4b4fdc83fe59eda98f7d0b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_558bb418da4b4fdc83fe59eda98f7d0b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_558bb418da4b4fdc83fe59eda98f7d0b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_558bb418da4b4fdc83fe59eda98f7d0b(_398ba3a349c82544ab73dce8ac0866a4_558bb418da4b4fdc83fe59eda98f7d0b command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_093fc1c4c1c549c79c6ee9f7707f713d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_093fc1c4c1c549c79c6ee9f7707f713d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_093fc1c4c1c549c79c6ee9f7707f713d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_093fc1c4c1c549c79c6ee9f7707f713d(_398ba3a349c82544ab73dce8ac0866a4_093fc1c4c1c549c79c6ee9f7707f713d command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_b6f63d37016645c497b888ac457cde13(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_b6f63d37016645c497b888ac457cde13(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_b6f63d37016645c497b888ac457cde13(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_b6f63d37016645c497b888ac457cde13(_398ba3a349c82544ab73dce8ac0866a4_b6f63d37016645c497b888ac457cde13 command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_e65f6679521e4b1c9cba9ae463c6a338(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_e65f6679521e4b1c9cba9ae463c6a338(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_e65f6679521e4b1c9cba9ae463c6a338(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_e65f6679521e4b1c9cba9ae463c6a338(_398ba3a349c82544ab73dce8ac0866a4_e65f6679521e4b1c9cba9ae463c6a338 command)
		{
		}

		private void BakeCommandBinding__398ba3a349c82544ab73dce8ac0866a4_ac37c0fcfb7e42b9803faf23ed1628fa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__398ba3a349c82544ab73dce8ac0866a4_ac37c0fcfb7e42b9803faf23ed1628fa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__398ba3a349c82544ab73dce8ac0866a4_ac37c0fcfb7e42b9803faf23ed1628fa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__398ba3a349c82544ab73dce8ac0866a4_ac37c0fcfb7e42b9803faf23ed1628fa(_398ba3a349c82544ab73dce8ac0866a4_ac37c0fcfb7e42b9803faf23ed1628fa command)
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
