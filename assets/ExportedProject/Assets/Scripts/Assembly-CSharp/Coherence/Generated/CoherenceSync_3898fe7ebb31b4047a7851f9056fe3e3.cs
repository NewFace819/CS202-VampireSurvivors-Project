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
	public class CoherenceSync_3898fe7ebb31b4047a7851f9056fe3e3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_674abec328284001a6fa93e153d6762a_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_31755b2b6b834d36970004e09098dff0_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_c7e132ed15234bb4a96964d73e17a31f_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_78ef54dc0e1b40fab877079fcac79c51_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_5f03abf94cc04b648f77bcee05291607_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_d1f4d9d6ce8c4bd79afc7162fa32de8f_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_7cf66c72d4f748f587f0f61d879e4238_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_bfbaae50424447be91aca8ccd15bca21_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_79e9aef07c6e4d09aaddf6c904bec8f6_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_d890a83647b74586a8a6af0632f5a283_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_528f2501d59e442ab3beaa94a627a14a_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_83a8934a55184c3f8a23b7ef6ccd0b34_CommandTarget;

		private CharacterController _3898fe7ebb31b4047a7851f9056fe3e3_41ddf5fa29be434ca033b39329fd28c6_CommandTarget;

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

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_674abec328284001a6fa93e153d6762a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_674abec328284001a6fa93e153d6762a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_674abec328284001a6fa93e153d6762a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_674abec328284001a6fa93e153d6762a(_3898fe7ebb31b4047a7851f9056fe3e3_674abec328284001a6fa93e153d6762a command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_31755b2b6b834d36970004e09098dff0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_31755b2b6b834d36970004e09098dff0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_31755b2b6b834d36970004e09098dff0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_31755b2b6b834d36970004e09098dff0(_3898fe7ebb31b4047a7851f9056fe3e3_31755b2b6b834d36970004e09098dff0 command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_c7e132ed15234bb4a96964d73e17a31f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_c7e132ed15234bb4a96964d73e17a31f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_c7e132ed15234bb4a96964d73e17a31f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_c7e132ed15234bb4a96964d73e17a31f(_3898fe7ebb31b4047a7851f9056fe3e3_c7e132ed15234bb4a96964d73e17a31f command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_78ef54dc0e1b40fab877079fcac79c51(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_78ef54dc0e1b40fab877079fcac79c51(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_78ef54dc0e1b40fab877079fcac79c51(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_78ef54dc0e1b40fab877079fcac79c51(_3898fe7ebb31b4047a7851f9056fe3e3_78ef54dc0e1b40fab877079fcac79c51 command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_5f03abf94cc04b648f77bcee05291607(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_5f03abf94cc04b648f77bcee05291607(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_5f03abf94cc04b648f77bcee05291607(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_5f03abf94cc04b648f77bcee05291607(_3898fe7ebb31b4047a7851f9056fe3e3_5f03abf94cc04b648f77bcee05291607 command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_d1f4d9d6ce8c4bd79afc7162fa32de8f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_d1f4d9d6ce8c4bd79afc7162fa32de8f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_d1f4d9d6ce8c4bd79afc7162fa32de8f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_d1f4d9d6ce8c4bd79afc7162fa32de8f(_3898fe7ebb31b4047a7851f9056fe3e3_d1f4d9d6ce8c4bd79afc7162fa32de8f command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_7cf66c72d4f748f587f0f61d879e4238(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_7cf66c72d4f748f587f0f61d879e4238(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_7cf66c72d4f748f587f0f61d879e4238(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_7cf66c72d4f748f587f0f61d879e4238(_3898fe7ebb31b4047a7851f9056fe3e3_7cf66c72d4f748f587f0f61d879e4238 command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_bfbaae50424447be91aca8ccd15bca21(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_bfbaae50424447be91aca8ccd15bca21(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_bfbaae50424447be91aca8ccd15bca21(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_bfbaae50424447be91aca8ccd15bca21(_3898fe7ebb31b4047a7851f9056fe3e3_bfbaae50424447be91aca8ccd15bca21 command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_79e9aef07c6e4d09aaddf6c904bec8f6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_79e9aef07c6e4d09aaddf6c904bec8f6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_79e9aef07c6e4d09aaddf6c904bec8f6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_79e9aef07c6e4d09aaddf6c904bec8f6(_3898fe7ebb31b4047a7851f9056fe3e3_79e9aef07c6e4d09aaddf6c904bec8f6 command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_d890a83647b74586a8a6af0632f5a283(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_d890a83647b74586a8a6af0632f5a283(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_d890a83647b74586a8a6af0632f5a283(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_d890a83647b74586a8a6af0632f5a283(_3898fe7ebb31b4047a7851f9056fe3e3_d890a83647b74586a8a6af0632f5a283 command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_528f2501d59e442ab3beaa94a627a14a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_528f2501d59e442ab3beaa94a627a14a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_528f2501d59e442ab3beaa94a627a14a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_528f2501d59e442ab3beaa94a627a14a(_3898fe7ebb31b4047a7851f9056fe3e3_528f2501d59e442ab3beaa94a627a14a command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_83a8934a55184c3f8a23b7ef6ccd0b34(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_83a8934a55184c3f8a23b7ef6ccd0b34(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_83a8934a55184c3f8a23b7ef6ccd0b34(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_83a8934a55184c3f8a23b7ef6ccd0b34(_3898fe7ebb31b4047a7851f9056fe3e3_83a8934a55184c3f8a23b7ef6ccd0b34 command)
		{
		}

		private void BakeCommandBinding__3898fe7ebb31b4047a7851f9056fe3e3_41ddf5fa29be434ca033b39329fd28c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3898fe7ebb31b4047a7851f9056fe3e3_41ddf5fa29be434ca033b39329fd28c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3898fe7ebb31b4047a7851f9056fe3e3_41ddf5fa29be434ca033b39329fd28c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3898fe7ebb31b4047a7851f9056fe3e3_41ddf5fa29be434ca033b39329fd28c6(_3898fe7ebb31b4047a7851f9056fe3e3_41ddf5fa29be434ca033b39329fd28c6 command)
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
