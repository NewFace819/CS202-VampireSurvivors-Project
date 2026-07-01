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
	public class CoherenceSync_b8bee74549629704993f756a95353f48 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _b8bee74549629704993f756a95353f48_21a4cb0be8de4aa28cc4715bf77489b0_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_1703b48de68443e3a37a18eccb9214d2_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_92f0dce27afa4398bad756a8b4b15b5b_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_df91998ec6a94467b367731bf926f23d_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_41da08acb0804ce6b3cbd0585b7b6264_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_92f2270be9b74ffeb59dffbffd9b4869_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_59829bd724ca4777b5930d801686f611_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_f661b51ee1e34b1990588dd10a169750_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_1b536c3a010c49c692111457b9f3814f_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_72fae04ffa0649b6bb8e517eae0714ac_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_136d04e9245f4006b05bb0131a1faacc_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_c9b283844d9946d2bf81ecc6a9d19004_CommandTarget;

		private CharacterController _b8bee74549629704993f756a95353f48_88d502b796c64825ba428cbf5316cb88_CommandTarget;

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

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_21a4cb0be8de4aa28cc4715bf77489b0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_21a4cb0be8de4aa28cc4715bf77489b0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_21a4cb0be8de4aa28cc4715bf77489b0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_21a4cb0be8de4aa28cc4715bf77489b0(_b8bee74549629704993f756a95353f48_21a4cb0be8de4aa28cc4715bf77489b0 command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_1703b48de68443e3a37a18eccb9214d2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_1703b48de68443e3a37a18eccb9214d2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_1703b48de68443e3a37a18eccb9214d2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_1703b48de68443e3a37a18eccb9214d2(_b8bee74549629704993f756a95353f48_1703b48de68443e3a37a18eccb9214d2 command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_92f0dce27afa4398bad756a8b4b15b5b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_92f0dce27afa4398bad756a8b4b15b5b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_92f0dce27afa4398bad756a8b4b15b5b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_92f0dce27afa4398bad756a8b4b15b5b(_b8bee74549629704993f756a95353f48_92f0dce27afa4398bad756a8b4b15b5b command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_df91998ec6a94467b367731bf926f23d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_df91998ec6a94467b367731bf926f23d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_df91998ec6a94467b367731bf926f23d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_df91998ec6a94467b367731bf926f23d(_b8bee74549629704993f756a95353f48_df91998ec6a94467b367731bf926f23d command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_41da08acb0804ce6b3cbd0585b7b6264(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_41da08acb0804ce6b3cbd0585b7b6264(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_41da08acb0804ce6b3cbd0585b7b6264(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_41da08acb0804ce6b3cbd0585b7b6264(_b8bee74549629704993f756a95353f48_41da08acb0804ce6b3cbd0585b7b6264 command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_92f2270be9b74ffeb59dffbffd9b4869(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_92f2270be9b74ffeb59dffbffd9b4869(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_92f2270be9b74ffeb59dffbffd9b4869(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_92f2270be9b74ffeb59dffbffd9b4869(_b8bee74549629704993f756a95353f48_92f2270be9b74ffeb59dffbffd9b4869 command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_59829bd724ca4777b5930d801686f611(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_59829bd724ca4777b5930d801686f611(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_59829bd724ca4777b5930d801686f611(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_59829bd724ca4777b5930d801686f611(_b8bee74549629704993f756a95353f48_59829bd724ca4777b5930d801686f611 command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_f661b51ee1e34b1990588dd10a169750(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_f661b51ee1e34b1990588dd10a169750(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_f661b51ee1e34b1990588dd10a169750(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_f661b51ee1e34b1990588dd10a169750(_b8bee74549629704993f756a95353f48_f661b51ee1e34b1990588dd10a169750 command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_1b536c3a010c49c692111457b9f3814f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_1b536c3a010c49c692111457b9f3814f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_1b536c3a010c49c692111457b9f3814f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_1b536c3a010c49c692111457b9f3814f(_b8bee74549629704993f756a95353f48_1b536c3a010c49c692111457b9f3814f command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_72fae04ffa0649b6bb8e517eae0714ac(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_72fae04ffa0649b6bb8e517eae0714ac(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_72fae04ffa0649b6bb8e517eae0714ac(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_72fae04ffa0649b6bb8e517eae0714ac(_b8bee74549629704993f756a95353f48_72fae04ffa0649b6bb8e517eae0714ac command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_136d04e9245f4006b05bb0131a1faacc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_136d04e9245f4006b05bb0131a1faacc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_136d04e9245f4006b05bb0131a1faacc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_136d04e9245f4006b05bb0131a1faacc(_b8bee74549629704993f756a95353f48_136d04e9245f4006b05bb0131a1faacc command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_c9b283844d9946d2bf81ecc6a9d19004(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_c9b283844d9946d2bf81ecc6a9d19004(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_c9b283844d9946d2bf81ecc6a9d19004(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_c9b283844d9946d2bf81ecc6a9d19004(_b8bee74549629704993f756a95353f48_c9b283844d9946d2bf81ecc6a9d19004 command)
		{
		}

		private void BakeCommandBinding__b8bee74549629704993f756a95353f48_88d502b796c64825ba428cbf5316cb88(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b8bee74549629704993f756a95353f48_88d502b796c64825ba428cbf5316cb88(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b8bee74549629704993f756a95353f48_88d502b796c64825ba428cbf5316cb88(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b8bee74549629704993f756a95353f48_88d502b796c64825ba428cbf5316cb88(_b8bee74549629704993f756a95353f48_88d502b796c64825ba428cbf5316cb88 command)
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
