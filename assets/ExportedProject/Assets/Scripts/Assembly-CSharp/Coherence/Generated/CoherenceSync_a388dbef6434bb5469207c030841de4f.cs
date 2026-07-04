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
	public class CoherenceSync_a388dbef6434bb5469207c030841de4f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a388dbef6434bb5469207c030841de4f_6cc5b4e85f0d488fa2c4a488691c1654_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_194d69e8431c4901964fb5ea238b9215_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_74d88d3cf7c44202bfc2399a13eaacd2_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_aeb3b482c7ab47b6a861138cc66c5871_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_5c5e07e791aa43be9055498d10d9ed86_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_fb9dfaf1f7bd469f89a8cade4164ddb6_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_a46300195a9c4c9c95c2b05f39940a30_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_23943379405148419b097d087db0f729_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_cbfe22e888674dbbb75804cd61bd086a_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_d2f75c93e3244c7ba813247b839c6ae1_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_80b6beb4a0ab4bbdb9e619c9084b9175_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_75db677b8ad34ffa8dec6c4293915aa3_CommandTarget;

		private CharacterController _a388dbef6434bb5469207c030841de4f_f1cc03c8dcea42498912d70653f6c4b5_CommandTarget;

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

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_6cc5b4e85f0d488fa2c4a488691c1654(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_6cc5b4e85f0d488fa2c4a488691c1654(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_6cc5b4e85f0d488fa2c4a488691c1654(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_6cc5b4e85f0d488fa2c4a488691c1654(_a388dbef6434bb5469207c030841de4f_6cc5b4e85f0d488fa2c4a488691c1654 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_194d69e8431c4901964fb5ea238b9215(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_194d69e8431c4901964fb5ea238b9215(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_194d69e8431c4901964fb5ea238b9215(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_194d69e8431c4901964fb5ea238b9215(_a388dbef6434bb5469207c030841de4f_194d69e8431c4901964fb5ea238b9215 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_74d88d3cf7c44202bfc2399a13eaacd2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_74d88d3cf7c44202bfc2399a13eaacd2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_74d88d3cf7c44202bfc2399a13eaacd2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_74d88d3cf7c44202bfc2399a13eaacd2(_a388dbef6434bb5469207c030841de4f_74d88d3cf7c44202bfc2399a13eaacd2 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_aeb3b482c7ab47b6a861138cc66c5871(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_aeb3b482c7ab47b6a861138cc66c5871(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_aeb3b482c7ab47b6a861138cc66c5871(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_aeb3b482c7ab47b6a861138cc66c5871(_a388dbef6434bb5469207c030841de4f_aeb3b482c7ab47b6a861138cc66c5871 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_5c5e07e791aa43be9055498d10d9ed86(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_5c5e07e791aa43be9055498d10d9ed86(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_5c5e07e791aa43be9055498d10d9ed86(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_5c5e07e791aa43be9055498d10d9ed86(_a388dbef6434bb5469207c030841de4f_5c5e07e791aa43be9055498d10d9ed86 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_fb9dfaf1f7bd469f89a8cade4164ddb6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_fb9dfaf1f7bd469f89a8cade4164ddb6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_fb9dfaf1f7bd469f89a8cade4164ddb6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_fb9dfaf1f7bd469f89a8cade4164ddb6(_a388dbef6434bb5469207c030841de4f_fb9dfaf1f7bd469f89a8cade4164ddb6 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_a46300195a9c4c9c95c2b05f39940a30(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_a46300195a9c4c9c95c2b05f39940a30(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_a46300195a9c4c9c95c2b05f39940a30(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_a46300195a9c4c9c95c2b05f39940a30(_a388dbef6434bb5469207c030841de4f_a46300195a9c4c9c95c2b05f39940a30 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_23943379405148419b097d087db0f729(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_23943379405148419b097d087db0f729(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_23943379405148419b097d087db0f729(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_23943379405148419b097d087db0f729(_a388dbef6434bb5469207c030841de4f_23943379405148419b097d087db0f729 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_cbfe22e888674dbbb75804cd61bd086a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_cbfe22e888674dbbb75804cd61bd086a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_cbfe22e888674dbbb75804cd61bd086a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_cbfe22e888674dbbb75804cd61bd086a(_a388dbef6434bb5469207c030841de4f_cbfe22e888674dbbb75804cd61bd086a command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_d2f75c93e3244c7ba813247b839c6ae1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_d2f75c93e3244c7ba813247b839c6ae1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_d2f75c93e3244c7ba813247b839c6ae1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_d2f75c93e3244c7ba813247b839c6ae1(_a388dbef6434bb5469207c030841de4f_d2f75c93e3244c7ba813247b839c6ae1 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_80b6beb4a0ab4bbdb9e619c9084b9175(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_80b6beb4a0ab4bbdb9e619c9084b9175(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_80b6beb4a0ab4bbdb9e619c9084b9175(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_80b6beb4a0ab4bbdb9e619c9084b9175(_a388dbef6434bb5469207c030841de4f_80b6beb4a0ab4bbdb9e619c9084b9175 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_75db677b8ad34ffa8dec6c4293915aa3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_75db677b8ad34ffa8dec6c4293915aa3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_75db677b8ad34ffa8dec6c4293915aa3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_75db677b8ad34ffa8dec6c4293915aa3(_a388dbef6434bb5469207c030841de4f_75db677b8ad34ffa8dec6c4293915aa3 command)
		{
		}

		private void BakeCommandBinding__a388dbef6434bb5469207c030841de4f_f1cc03c8dcea42498912d70653f6c4b5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a388dbef6434bb5469207c030841de4f_f1cc03c8dcea42498912d70653f6c4b5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a388dbef6434bb5469207c030841de4f_f1cc03c8dcea42498912d70653f6c4b5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a388dbef6434bb5469207c030841de4f_f1cc03c8dcea42498912d70653f6c4b5(_a388dbef6434bb5469207c030841de4f_f1cc03c8dcea42498912d70653f6c4b5 command)
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
