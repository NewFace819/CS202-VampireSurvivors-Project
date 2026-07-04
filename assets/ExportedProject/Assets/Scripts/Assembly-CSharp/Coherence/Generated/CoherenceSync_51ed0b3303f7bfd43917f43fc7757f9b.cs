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
	public class CoherenceSync_51ed0b3303f7bfd43917f43fc7757f9b : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_77b03086c26847968a1f5867728eb916_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_edd3dad1b43c491aa0ff5281ab957da8_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_67c9598740324321ad831985d8b2dcb4_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_5420027bc84544829a0f49fce7e66ab4_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_9501ab9db2734fa4b0a83e9ed546a069_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_7198d5d2390348fca47752b04200f5b8_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_4cc5296934e341fa936462be1cfeafa6_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_4ff9015da98041edab7b5c7bd672f0e7_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_5e0cd402c94542b6b9f9da7e294f11a5_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_261d5d7a490745f3a9146ed849b410db_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_5009a803986e4dd788be08240350a87f_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_d21f4ad364364d1fbb55b90154b8af01_CommandTarget;

		private CharacterController _51ed0b3303f7bfd43917f43fc7757f9b_cf4fb1dae22a42f6b22bc461740a5f0c_CommandTarget;

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

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_77b03086c26847968a1f5867728eb916(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_77b03086c26847968a1f5867728eb916(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_77b03086c26847968a1f5867728eb916(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_77b03086c26847968a1f5867728eb916(_51ed0b3303f7bfd43917f43fc7757f9b_77b03086c26847968a1f5867728eb916 command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_edd3dad1b43c491aa0ff5281ab957da8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_edd3dad1b43c491aa0ff5281ab957da8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_edd3dad1b43c491aa0ff5281ab957da8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_edd3dad1b43c491aa0ff5281ab957da8(_51ed0b3303f7bfd43917f43fc7757f9b_edd3dad1b43c491aa0ff5281ab957da8 command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_67c9598740324321ad831985d8b2dcb4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_67c9598740324321ad831985d8b2dcb4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_67c9598740324321ad831985d8b2dcb4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_67c9598740324321ad831985d8b2dcb4(_51ed0b3303f7bfd43917f43fc7757f9b_67c9598740324321ad831985d8b2dcb4 command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_5420027bc84544829a0f49fce7e66ab4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_5420027bc84544829a0f49fce7e66ab4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_5420027bc84544829a0f49fce7e66ab4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_5420027bc84544829a0f49fce7e66ab4(_51ed0b3303f7bfd43917f43fc7757f9b_5420027bc84544829a0f49fce7e66ab4 command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_9501ab9db2734fa4b0a83e9ed546a069(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_9501ab9db2734fa4b0a83e9ed546a069(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_9501ab9db2734fa4b0a83e9ed546a069(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_9501ab9db2734fa4b0a83e9ed546a069(_51ed0b3303f7bfd43917f43fc7757f9b_9501ab9db2734fa4b0a83e9ed546a069 command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_7198d5d2390348fca47752b04200f5b8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_7198d5d2390348fca47752b04200f5b8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_7198d5d2390348fca47752b04200f5b8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_7198d5d2390348fca47752b04200f5b8(_51ed0b3303f7bfd43917f43fc7757f9b_7198d5d2390348fca47752b04200f5b8 command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_4cc5296934e341fa936462be1cfeafa6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_4cc5296934e341fa936462be1cfeafa6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_4cc5296934e341fa936462be1cfeafa6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_4cc5296934e341fa936462be1cfeafa6(_51ed0b3303f7bfd43917f43fc7757f9b_4cc5296934e341fa936462be1cfeafa6 command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_4ff9015da98041edab7b5c7bd672f0e7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_4ff9015da98041edab7b5c7bd672f0e7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_4ff9015da98041edab7b5c7bd672f0e7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_4ff9015da98041edab7b5c7bd672f0e7(_51ed0b3303f7bfd43917f43fc7757f9b_4ff9015da98041edab7b5c7bd672f0e7 command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_5e0cd402c94542b6b9f9da7e294f11a5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_5e0cd402c94542b6b9f9da7e294f11a5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_5e0cd402c94542b6b9f9da7e294f11a5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_5e0cd402c94542b6b9f9da7e294f11a5(_51ed0b3303f7bfd43917f43fc7757f9b_5e0cd402c94542b6b9f9da7e294f11a5 command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_261d5d7a490745f3a9146ed849b410db(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_261d5d7a490745f3a9146ed849b410db(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_261d5d7a490745f3a9146ed849b410db(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_261d5d7a490745f3a9146ed849b410db(_51ed0b3303f7bfd43917f43fc7757f9b_261d5d7a490745f3a9146ed849b410db command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_5009a803986e4dd788be08240350a87f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_5009a803986e4dd788be08240350a87f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_5009a803986e4dd788be08240350a87f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_5009a803986e4dd788be08240350a87f(_51ed0b3303f7bfd43917f43fc7757f9b_5009a803986e4dd788be08240350a87f command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_d21f4ad364364d1fbb55b90154b8af01(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_d21f4ad364364d1fbb55b90154b8af01(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_d21f4ad364364d1fbb55b90154b8af01(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_d21f4ad364364d1fbb55b90154b8af01(_51ed0b3303f7bfd43917f43fc7757f9b_d21f4ad364364d1fbb55b90154b8af01 command)
		{
		}

		private void BakeCommandBinding__51ed0b3303f7bfd43917f43fc7757f9b_cf4fb1dae22a42f6b22bc461740a5f0c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51ed0b3303f7bfd43917f43fc7757f9b_cf4fb1dae22a42f6b22bc461740a5f0c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51ed0b3303f7bfd43917f43fc7757f9b_cf4fb1dae22a42f6b22bc461740a5f0c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51ed0b3303f7bfd43917f43fc7757f9b_cf4fb1dae22a42f6b22bc461740a5f0c(_51ed0b3303f7bfd43917f43fc7757f9b_cf4fb1dae22a42f6b22bc461740a5f0c command)
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
