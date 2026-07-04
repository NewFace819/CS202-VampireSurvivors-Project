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
	public class CoherenceSync_f11f3c87b586d4b4e867cd143a1d76e1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_6a907a4c193640c285a93233a14b365f_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_28ae21bcf22c4759b59f7967072994c7_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_139b25cd892c4fcbb68ff8acb42baca6_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_32849c12106f4498aee78f724469ded1_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_a9ea89604a884fdea8eaa8108c026fb6_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_c8efba26bdd9422ba5ae6a7a40034c53_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_57322369893943d3a5cb7fd3d89becbc_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_b31f9d50c76d408f93aa386f1eb5144f_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_4e88f9b58f8e417ca5d87a276512a246_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_1aa9f5c8423b4da98eda2a568c2f4e02_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_ebbc29f9513f4c29964aea35f5301ed6_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_24844485b38f47b09b7967c2aeeb1721_CommandTarget;

		private CharacterController _f11f3c87b586d4b4e867cd143a1d76e1_29aef48dbc2e4355becd8fe573092ced_CommandTarget;

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

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_6a907a4c193640c285a93233a14b365f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_6a907a4c193640c285a93233a14b365f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_6a907a4c193640c285a93233a14b365f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_6a907a4c193640c285a93233a14b365f(_f11f3c87b586d4b4e867cd143a1d76e1_6a907a4c193640c285a93233a14b365f command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_28ae21bcf22c4759b59f7967072994c7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_28ae21bcf22c4759b59f7967072994c7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_28ae21bcf22c4759b59f7967072994c7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_28ae21bcf22c4759b59f7967072994c7(_f11f3c87b586d4b4e867cd143a1d76e1_28ae21bcf22c4759b59f7967072994c7 command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_139b25cd892c4fcbb68ff8acb42baca6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_139b25cd892c4fcbb68ff8acb42baca6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_139b25cd892c4fcbb68ff8acb42baca6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_139b25cd892c4fcbb68ff8acb42baca6(_f11f3c87b586d4b4e867cd143a1d76e1_139b25cd892c4fcbb68ff8acb42baca6 command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_32849c12106f4498aee78f724469ded1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_32849c12106f4498aee78f724469ded1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_32849c12106f4498aee78f724469ded1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_32849c12106f4498aee78f724469ded1(_f11f3c87b586d4b4e867cd143a1d76e1_32849c12106f4498aee78f724469ded1 command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_a9ea89604a884fdea8eaa8108c026fb6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_a9ea89604a884fdea8eaa8108c026fb6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_a9ea89604a884fdea8eaa8108c026fb6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_a9ea89604a884fdea8eaa8108c026fb6(_f11f3c87b586d4b4e867cd143a1d76e1_a9ea89604a884fdea8eaa8108c026fb6 command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_c8efba26bdd9422ba5ae6a7a40034c53(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_c8efba26bdd9422ba5ae6a7a40034c53(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_c8efba26bdd9422ba5ae6a7a40034c53(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_c8efba26bdd9422ba5ae6a7a40034c53(_f11f3c87b586d4b4e867cd143a1d76e1_c8efba26bdd9422ba5ae6a7a40034c53 command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_57322369893943d3a5cb7fd3d89becbc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_57322369893943d3a5cb7fd3d89becbc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_57322369893943d3a5cb7fd3d89becbc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_57322369893943d3a5cb7fd3d89becbc(_f11f3c87b586d4b4e867cd143a1d76e1_57322369893943d3a5cb7fd3d89becbc command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_b31f9d50c76d408f93aa386f1eb5144f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_b31f9d50c76d408f93aa386f1eb5144f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_b31f9d50c76d408f93aa386f1eb5144f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_b31f9d50c76d408f93aa386f1eb5144f(_f11f3c87b586d4b4e867cd143a1d76e1_b31f9d50c76d408f93aa386f1eb5144f command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_4e88f9b58f8e417ca5d87a276512a246(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_4e88f9b58f8e417ca5d87a276512a246(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_4e88f9b58f8e417ca5d87a276512a246(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_4e88f9b58f8e417ca5d87a276512a246(_f11f3c87b586d4b4e867cd143a1d76e1_4e88f9b58f8e417ca5d87a276512a246 command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_1aa9f5c8423b4da98eda2a568c2f4e02(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_1aa9f5c8423b4da98eda2a568c2f4e02(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_1aa9f5c8423b4da98eda2a568c2f4e02(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_1aa9f5c8423b4da98eda2a568c2f4e02(_f11f3c87b586d4b4e867cd143a1d76e1_1aa9f5c8423b4da98eda2a568c2f4e02 command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_ebbc29f9513f4c29964aea35f5301ed6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_ebbc29f9513f4c29964aea35f5301ed6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_ebbc29f9513f4c29964aea35f5301ed6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_ebbc29f9513f4c29964aea35f5301ed6(_f11f3c87b586d4b4e867cd143a1d76e1_ebbc29f9513f4c29964aea35f5301ed6 command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_24844485b38f47b09b7967c2aeeb1721(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_24844485b38f47b09b7967c2aeeb1721(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_24844485b38f47b09b7967c2aeeb1721(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_24844485b38f47b09b7967c2aeeb1721(_f11f3c87b586d4b4e867cd143a1d76e1_24844485b38f47b09b7967c2aeeb1721 command)
		{
		}

		private void BakeCommandBinding__f11f3c87b586d4b4e867cd143a1d76e1_29aef48dbc2e4355becd8fe573092ced(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f11f3c87b586d4b4e867cd143a1d76e1_29aef48dbc2e4355becd8fe573092ced(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f11f3c87b586d4b4e867cd143a1d76e1_29aef48dbc2e4355becd8fe573092ced(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f11f3c87b586d4b4e867cd143a1d76e1_29aef48dbc2e4355becd8fe573092ced(_f11f3c87b586d4b4e867cd143a1d76e1_29aef48dbc2e4355becd8fe573092ced command)
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
