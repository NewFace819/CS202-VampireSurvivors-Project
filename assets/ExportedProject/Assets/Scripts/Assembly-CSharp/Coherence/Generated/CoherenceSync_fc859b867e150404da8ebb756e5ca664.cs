using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;
using VampireSurvivors.Objects.Items;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_fc859b867e150404da8ebb756e5ca664 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private Pickup_EME_Cat _fc859b867e150404da8ebb756e5ca664_d96e344b51034aecb79630b3a5c6f364_CommandTarget;

		private NetworkPickup _fc859b867e150404da8ebb756e5ca664_cf4e552f69b545d99a2ded140683276a_CommandTarget;

		private NetworkPickup _fc859b867e150404da8ebb756e5ca664_6b8d570b37344e459d71ff84528dfeb3_CommandTarget;

		private NetworkPickup _fc859b867e150404da8ebb756e5ca664_1f4538eded474c9da6dd09ac793b8eb4_CommandTarget;

		private NetworkPickup _fc859b867e150404da8ebb756e5ca664_ce27e796293345be9e5d78b95bfbabc4_CommandTarget;

		private NetworkPickup _fc859b867e150404da8ebb756e5ca664_28ecbfa3c8bd4e6eb60331a4e14982b6_CommandTarget;

		private NetworkPickup _fc859b867e150404da8ebb756e5ca664_e8ae3946c84c4f7bbac92e2a986b62ee_CommandTarget;

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

		private void BakeCommandBinding__fc859b867e150404da8ebb756e5ca664_d96e344b51034aecb79630b3a5c6f364(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fc859b867e150404da8ebb756e5ca664_d96e344b51034aecb79630b3a5c6f364(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fc859b867e150404da8ebb756e5ca664_d96e344b51034aecb79630b3a5c6f364(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fc859b867e150404da8ebb756e5ca664_d96e344b51034aecb79630b3a5c6f364(_fc859b867e150404da8ebb756e5ca664_d96e344b51034aecb79630b3a5c6f364 command)
		{
		}

		private void BakeCommandBinding__fc859b867e150404da8ebb756e5ca664_cf4e552f69b545d99a2ded140683276a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fc859b867e150404da8ebb756e5ca664_cf4e552f69b545d99a2ded140683276a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fc859b867e150404da8ebb756e5ca664_cf4e552f69b545d99a2ded140683276a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fc859b867e150404da8ebb756e5ca664_cf4e552f69b545d99a2ded140683276a(_fc859b867e150404da8ebb756e5ca664_cf4e552f69b545d99a2ded140683276a command)
		{
		}

		private void BakeCommandBinding__fc859b867e150404da8ebb756e5ca664_6b8d570b37344e459d71ff84528dfeb3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fc859b867e150404da8ebb756e5ca664_6b8d570b37344e459d71ff84528dfeb3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fc859b867e150404da8ebb756e5ca664_6b8d570b37344e459d71ff84528dfeb3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fc859b867e150404da8ebb756e5ca664_6b8d570b37344e459d71ff84528dfeb3(_fc859b867e150404da8ebb756e5ca664_6b8d570b37344e459d71ff84528dfeb3 command)
		{
		}

		private void BakeCommandBinding__fc859b867e150404da8ebb756e5ca664_1f4538eded474c9da6dd09ac793b8eb4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fc859b867e150404da8ebb756e5ca664_1f4538eded474c9da6dd09ac793b8eb4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fc859b867e150404da8ebb756e5ca664_1f4538eded474c9da6dd09ac793b8eb4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fc859b867e150404da8ebb756e5ca664_1f4538eded474c9da6dd09ac793b8eb4(_fc859b867e150404da8ebb756e5ca664_1f4538eded474c9da6dd09ac793b8eb4 command)
		{
		}

		private void BakeCommandBinding__fc859b867e150404da8ebb756e5ca664_ce27e796293345be9e5d78b95bfbabc4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fc859b867e150404da8ebb756e5ca664_ce27e796293345be9e5d78b95bfbabc4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fc859b867e150404da8ebb756e5ca664_ce27e796293345be9e5d78b95bfbabc4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fc859b867e150404da8ebb756e5ca664_ce27e796293345be9e5d78b95bfbabc4(_fc859b867e150404da8ebb756e5ca664_ce27e796293345be9e5d78b95bfbabc4 command)
		{
		}

		private void BakeCommandBinding__fc859b867e150404da8ebb756e5ca664_28ecbfa3c8bd4e6eb60331a4e14982b6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fc859b867e150404da8ebb756e5ca664_28ecbfa3c8bd4e6eb60331a4e14982b6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fc859b867e150404da8ebb756e5ca664_28ecbfa3c8bd4e6eb60331a4e14982b6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fc859b867e150404da8ebb756e5ca664_28ecbfa3c8bd4e6eb60331a4e14982b6(_fc859b867e150404da8ebb756e5ca664_28ecbfa3c8bd4e6eb60331a4e14982b6 command)
		{
		}

		private void BakeCommandBinding__fc859b867e150404da8ebb756e5ca664_e8ae3946c84c4f7bbac92e2a986b62ee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fc859b867e150404da8ebb756e5ca664_e8ae3946c84c4f7bbac92e2a986b62ee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fc859b867e150404da8ebb756e5ca664_e8ae3946c84c4f7bbac92e2a986b62ee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fc859b867e150404da8ebb756e5ca664_e8ae3946c84c4f7bbac92e2a986b62ee(_fc859b867e150404da8ebb756e5ca664_e8ae3946c84c4f7bbac92e2a986b62ee command)
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
