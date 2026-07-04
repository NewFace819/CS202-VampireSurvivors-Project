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
	public class CoherenceSync_ef11fd415a87c334b834f7d07d58919f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_01a158062fe94cbd930b0c0d98bde6f1_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_91b3ae7a788b401caab076511a96999a_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_0ab051f1ace04595bf8319331617c284_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_643e2ff483ca45b8845a3f898740a61b_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_8cc5e62d2bd54a8d84c16089a19813c4_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_f0fddb7a7f4a4165951591d852ea3d94_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_42dbf91b7a51422181066d5ef06139f4_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_dd214d1153ab4328966630e5481fb284_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_92cf1a79fa4548198772906545e8dcbc_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_084b02f992c7489db4c745e092ab0bd7_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_ea72dd91a4d24a718dd2e59c6bbfbedc_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_c178917fbab647f4a80fd2a30d0297e9_CommandTarget;

		private CharacterController _ef11fd415a87c334b834f7d07d58919f_129eaab366b3478db318c159d0f9321f_CommandTarget;

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

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_01a158062fe94cbd930b0c0d98bde6f1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_01a158062fe94cbd930b0c0d98bde6f1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_01a158062fe94cbd930b0c0d98bde6f1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_01a158062fe94cbd930b0c0d98bde6f1(_ef11fd415a87c334b834f7d07d58919f_01a158062fe94cbd930b0c0d98bde6f1 command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_91b3ae7a788b401caab076511a96999a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_91b3ae7a788b401caab076511a96999a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_91b3ae7a788b401caab076511a96999a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_91b3ae7a788b401caab076511a96999a(_ef11fd415a87c334b834f7d07d58919f_91b3ae7a788b401caab076511a96999a command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_0ab051f1ace04595bf8319331617c284(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_0ab051f1ace04595bf8319331617c284(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_0ab051f1ace04595bf8319331617c284(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_0ab051f1ace04595bf8319331617c284(_ef11fd415a87c334b834f7d07d58919f_0ab051f1ace04595bf8319331617c284 command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_643e2ff483ca45b8845a3f898740a61b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_643e2ff483ca45b8845a3f898740a61b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_643e2ff483ca45b8845a3f898740a61b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_643e2ff483ca45b8845a3f898740a61b(_ef11fd415a87c334b834f7d07d58919f_643e2ff483ca45b8845a3f898740a61b command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_8cc5e62d2bd54a8d84c16089a19813c4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_8cc5e62d2bd54a8d84c16089a19813c4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_8cc5e62d2bd54a8d84c16089a19813c4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_8cc5e62d2bd54a8d84c16089a19813c4(_ef11fd415a87c334b834f7d07d58919f_8cc5e62d2bd54a8d84c16089a19813c4 command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_f0fddb7a7f4a4165951591d852ea3d94(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_f0fddb7a7f4a4165951591d852ea3d94(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_f0fddb7a7f4a4165951591d852ea3d94(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_f0fddb7a7f4a4165951591d852ea3d94(_ef11fd415a87c334b834f7d07d58919f_f0fddb7a7f4a4165951591d852ea3d94 command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_42dbf91b7a51422181066d5ef06139f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_42dbf91b7a51422181066d5ef06139f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_42dbf91b7a51422181066d5ef06139f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_42dbf91b7a51422181066d5ef06139f4(_ef11fd415a87c334b834f7d07d58919f_42dbf91b7a51422181066d5ef06139f4 command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_dd214d1153ab4328966630e5481fb284(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_dd214d1153ab4328966630e5481fb284(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_dd214d1153ab4328966630e5481fb284(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_dd214d1153ab4328966630e5481fb284(_ef11fd415a87c334b834f7d07d58919f_dd214d1153ab4328966630e5481fb284 command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_92cf1a79fa4548198772906545e8dcbc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_92cf1a79fa4548198772906545e8dcbc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_92cf1a79fa4548198772906545e8dcbc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_92cf1a79fa4548198772906545e8dcbc(_ef11fd415a87c334b834f7d07d58919f_92cf1a79fa4548198772906545e8dcbc command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_084b02f992c7489db4c745e092ab0bd7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_084b02f992c7489db4c745e092ab0bd7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_084b02f992c7489db4c745e092ab0bd7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_084b02f992c7489db4c745e092ab0bd7(_ef11fd415a87c334b834f7d07d58919f_084b02f992c7489db4c745e092ab0bd7 command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_ea72dd91a4d24a718dd2e59c6bbfbedc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_ea72dd91a4d24a718dd2e59c6bbfbedc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_ea72dd91a4d24a718dd2e59c6bbfbedc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_ea72dd91a4d24a718dd2e59c6bbfbedc(_ef11fd415a87c334b834f7d07d58919f_ea72dd91a4d24a718dd2e59c6bbfbedc command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_c178917fbab647f4a80fd2a30d0297e9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_c178917fbab647f4a80fd2a30d0297e9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_c178917fbab647f4a80fd2a30d0297e9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_c178917fbab647f4a80fd2a30d0297e9(_ef11fd415a87c334b834f7d07d58919f_c178917fbab647f4a80fd2a30d0297e9 command)
		{
		}

		private void BakeCommandBinding__ef11fd415a87c334b834f7d07d58919f_129eaab366b3478db318c159d0f9321f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ef11fd415a87c334b834f7d07d58919f_129eaab366b3478db318c159d0f9321f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ef11fd415a87c334b834f7d07d58919f_129eaab366b3478db318c159d0f9321f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ef11fd415a87c334b834f7d07d58919f_129eaab366b3478db318c159d0f9321f(_ef11fd415a87c334b834f7d07d58919f_129eaab366b3478db318c159d0f9321f command)
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
