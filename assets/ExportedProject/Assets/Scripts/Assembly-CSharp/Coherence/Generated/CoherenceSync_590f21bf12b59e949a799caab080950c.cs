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
	public class CoherenceSync_590f21bf12b59e949a799caab080950c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _590f21bf12b59e949a799caab080950c_7438aaae69ea4a64ae9b0dfd9227ca99_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_39469b7af2a84ded99ea7b34cfdfb004_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_4789835e97bc449d968c862d801ee411_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_5c38a54c056044c2aea7cd7a8ecdb9b0_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_09b0ace150ac4e7cb4431667b4008efe_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_36323d96d7e44627b0e269606b280bc7_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_80d7bfb807e944c1966262be58917e90_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_47cccb3041c54af2bcb9949280c82b7e_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_e805a38783ee4ec9878038cc3c593c58_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_82b13b76b16b49f29de45ef5e41b0dc0_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_8ccd780a377a4461b976c0ac449f7927_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_1270923550434cd599303e0de5fd2d2d_CommandTarget;

		private CharacterController _590f21bf12b59e949a799caab080950c_3417441d85c346c3bd1c629c7ee4667e_CommandTarget;

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

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_7438aaae69ea4a64ae9b0dfd9227ca99(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_7438aaae69ea4a64ae9b0dfd9227ca99(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_7438aaae69ea4a64ae9b0dfd9227ca99(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_7438aaae69ea4a64ae9b0dfd9227ca99(_590f21bf12b59e949a799caab080950c_7438aaae69ea4a64ae9b0dfd9227ca99 command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_39469b7af2a84ded99ea7b34cfdfb004(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_39469b7af2a84ded99ea7b34cfdfb004(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_39469b7af2a84ded99ea7b34cfdfb004(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_39469b7af2a84ded99ea7b34cfdfb004(_590f21bf12b59e949a799caab080950c_39469b7af2a84ded99ea7b34cfdfb004 command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_4789835e97bc449d968c862d801ee411(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_4789835e97bc449d968c862d801ee411(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_4789835e97bc449d968c862d801ee411(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_4789835e97bc449d968c862d801ee411(_590f21bf12b59e949a799caab080950c_4789835e97bc449d968c862d801ee411 command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_5c38a54c056044c2aea7cd7a8ecdb9b0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_5c38a54c056044c2aea7cd7a8ecdb9b0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_5c38a54c056044c2aea7cd7a8ecdb9b0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_5c38a54c056044c2aea7cd7a8ecdb9b0(_590f21bf12b59e949a799caab080950c_5c38a54c056044c2aea7cd7a8ecdb9b0 command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_09b0ace150ac4e7cb4431667b4008efe(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_09b0ace150ac4e7cb4431667b4008efe(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_09b0ace150ac4e7cb4431667b4008efe(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_09b0ace150ac4e7cb4431667b4008efe(_590f21bf12b59e949a799caab080950c_09b0ace150ac4e7cb4431667b4008efe command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_36323d96d7e44627b0e269606b280bc7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_36323d96d7e44627b0e269606b280bc7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_36323d96d7e44627b0e269606b280bc7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_36323d96d7e44627b0e269606b280bc7(_590f21bf12b59e949a799caab080950c_36323d96d7e44627b0e269606b280bc7 command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_80d7bfb807e944c1966262be58917e90(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_80d7bfb807e944c1966262be58917e90(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_80d7bfb807e944c1966262be58917e90(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_80d7bfb807e944c1966262be58917e90(_590f21bf12b59e949a799caab080950c_80d7bfb807e944c1966262be58917e90 command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_47cccb3041c54af2bcb9949280c82b7e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_47cccb3041c54af2bcb9949280c82b7e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_47cccb3041c54af2bcb9949280c82b7e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_47cccb3041c54af2bcb9949280c82b7e(_590f21bf12b59e949a799caab080950c_47cccb3041c54af2bcb9949280c82b7e command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_e805a38783ee4ec9878038cc3c593c58(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_e805a38783ee4ec9878038cc3c593c58(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_e805a38783ee4ec9878038cc3c593c58(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_e805a38783ee4ec9878038cc3c593c58(_590f21bf12b59e949a799caab080950c_e805a38783ee4ec9878038cc3c593c58 command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_82b13b76b16b49f29de45ef5e41b0dc0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_82b13b76b16b49f29de45ef5e41b0dc0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_82b13b76b16b49f29de45ef5e41b0dc0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_82b13b76b16b49f29de45ef5e41b0dc0(_590f21bf12b59e949a799caab080950c_82b13b76b16b49f29de45ef5e41b0dc0 command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_8ccd780a377a4461b976c0ac449f7927(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_8ccd780a377a4461b976c0ac449f7927(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_8ccd780a377a4461b976c0ac449f7927(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_8ccd780a377a4461b976c0ac449f7927(_590f21bf12b59e949a799caab080950c_8ccd780a377a4461b976c0ac449f7927 command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_1270923550434cd599303e0de5fd2d2d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_1270923550434cd599303e0de5fd2d2d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_1270923550434cd599303e0de5fd2d2d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_1270923550434cd599303e0de5fd2d2d(_590f21bf12b59e949a799caab080950c_1270923550434cd599303e0de5fd2d2d command)
		{
		}

		private void BakeCommandBinding__590f21bf12b59e949a799caab080950c_3417441d85c346c3bd1c629c7ee4667e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__590f21bf12b59e949a799caab080950c_3417441d85c346c3bd1c629c7ee4667e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__590f21bf12b59e949a799caab080950c_3417441d85c346c3bd1c629c7ee4667e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__590f21bf12b59e949a799caab080950c_3417441d85c346c3bd1c629c7ee4667e(_590f21bf12b59e949a799caab080950c_3417441d85c346c3bd1c629c7ee4667e command)
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
