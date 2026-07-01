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

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_5f68450e2e16f9746b7cdcbc4bdc7fe5 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _5f68450e2e16f9746b7cdcbc4bdc7fe5_700be85d35cf46bd9ee6ed59370c9cc0_CommandTarget;

		private NetworkPickup _5f68450e2e16f9746b7cdcbc4bdc7fe5_2aac41bb80a049dcbda254d264de7d99_CommandTarget;

		private NetworkPickup _5f68450e2e16f9746b7cdcbc4bdc7fe5_2866f3b7c56c4201820b834e28560df1_CommandTarget;

		private NetworkPickup _5f68450e2e16f9746b7cdcbc4bdc7fe5_9f52b6c7fb344d1eaf0c5adacd9a450c_CommandTarget;

		private NetworkPickup _5f68450e2e16f9746b7cdcbc4bdc7fe5_a052e61a89614d948d33130dc5deb2af_CommandTarget;

		private NetworkPickup _5f68450e2e16f9746b7cdcbc4bdc7fe5_0298fd06ce994903990748e0866b2a52_CommandTarget;

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

		private void BakeCommandBinding__5f68450e2e16f9746b7cdcbc4bdc7fe5_700be85d35cf46bd9ee6ed59370c9cc0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_700be85d35cf46bd9ee6ed59370c9cc0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_700be85d35cf46bd9ee6ed59370c9cc0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_700be85d35cf46bd9ee6ed59370c9cc0(_5f68450e2e16f9746b7cdcbc4bdc7fe5_700be85d35cf46bd9ee6ed59370c9cc0 command)
		{
		}

		private void BakeCommandBinding__5f68450e2e16f9746b7cdcbc4bdc7fe5_2aac41bb80a049dcbda254d264de7d99(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_2aac41bb80a049dcbda254d264de7d99(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_2aac41bb80a049dcbda254d264de7d99(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_2aac41bb80a049dcbda254d264de7d99(_5f68450e2e16f9746b7cdcbc4bdc7fe5_2aac41bb80a049dcbda254d264de7d99 command)
		{
		}

		private void BakeCommandBinding__5f68450e2e16f9746b7cdcbc4bdc7fe5_2866f3b7c56c4201820b834e28560df1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_2866f3b7c56c4201820b834e28560df1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_2866f3b7c56c4201820b834e28560df1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_2866f3b7c56c4201820b834e28560df1(_5f68450e2e16f9746b7cdcbc4bdc7fe5_2866f3b7c56c4201820b834e28560df1 command)
		{
		}

		private void BakeCommandBinding__5f68450e2e16f9746b7cdcbc4bdc7fe5_9f52b6c7fb344d1eaf0c5adacd9a450c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_9f52b6c7fb344d1eaf0c5adacd9a450c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_9f52b6c7fb344d1eaf0c5adacd9a450c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_9f52b6c7fb344d1eaf0c5adacd9a450c(_5f68450e2e16f9746b7cdcbc4bdc7fe5_9f52b6c7fb344d1eaf0c5adacd9a450c command)
		{
		}

		private void BakeCommandBinding__5f68450e2e16f9746b7cdcbc4bdc7fe5_a052e61a89614d948d33130dc5deb2af(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_a052e61a89614d948d33130dc5deb2af(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_a052e61a89614d948d33130dc5deb2af(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_a052e61a89614d948d33130dc5deb2af(_5f68450e2e16f9746b7cdcbc4bdc7fe5_a052e61a89614d948d33130dc5deb2af command)
		{
		}

		private void BakeCommandBinding__5f68450e2e16f9746b7cdcbc4bdc7fe5_0298fd06ce994903990748e0866b2a52(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_0298fd06ce994903990748e0866b2a52(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_0298fd06ce994903990748e0866b2a52(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f68450e2e16f9746b7cdcbc4bdc7fe5_0298fd06ce994903990748e0866b2a52(_5f68450e2e16f9746b7cdcbc4bdc7fe5_0298fd06ce994903990748e0866b2a52 command)
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
