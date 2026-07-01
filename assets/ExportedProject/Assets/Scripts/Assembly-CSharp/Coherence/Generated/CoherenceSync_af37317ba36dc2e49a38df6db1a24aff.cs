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
	public class CoherenceSync_af37317ba36dc2e49a38df6db1a24aff : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_f7a52a65d316492ea9194e1b4f7d2916_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_b532e572b17844d7af7bdca22a70aa6f_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_1fa5a6c55b3f4e2f9364a77a8bcab10b_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_f5397fdd86a7408f8dec63cd3567f6a8_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_1c8f7a80dd554273bfcc1d9051e41192_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_e9e4526a0c3743a0a9f392f99ad2dd45_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_9bce0cea735e4499afc5743bded21b40_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_021b12af921c470eafb1d9a772469f62_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_726d147cc96241c6881810002071c8f2_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_8f607f38dd28493894e4b9eb0107149d_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_8a5a329e07c2414196a130a638044544_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_2eeef225630a4397bb35e411f3066f6e_CommandTarget;

		private CharacterController _af37317ba36dc2e49a38df6db1a24aff_0219b742cf0e400b906f81738339f756_CommandTarget;

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

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_f7a52a65d316492ea9194e1b4f7d2916(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_f7a52a65d316492ea9194e1b4f7d2916(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_f7a52a65d316492ea9194e1b4f7d2916(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_f7a52a65d316492ea9194e1b4f7d2916(_af37317ba36dc2e49a38df6db1a24aff_f7a52a65d316492ea9194e1b4f7d2916 command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_b532e572b17844d7af7bdca22a70aa6f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_b532e572b17844d7af7bdca22a70aa6f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_b532e572b17844d7af7bdca22a70aa6f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_b532e572b17844d7af7bdca22a70aa6f(_af37317ba36dc2e49a38df6db1a24aff_b532e572b17844d7af7bdca22a70aa6f command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_1fa5a6c55b3f4e2f9364a77a8bcab10b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_1fa5a6c55b3f4e2f9364a77a8bcab10b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_1fa5a6c55b3f4e2f9364a77a8bcab10b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_1fa5a6c55b3f4e2f9364a77a8bcab10b(_af37317ba36dc2e49a38df6db1a24aff_1fa5a6c55b3f4e2f9364a77a8bcab10b command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_f5397fdd86a7408f8dec63cd3567f6a8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_f5397fdd86a7408f8dec63cd3567f6a8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_f5397fdd86a7408f8dec63cd3567f6a8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_f5397fdd86a7408f8dec63cd3567f6a8(_af37317ba36dc2e49a38df6db1a24aff_f5397fdd86a7408f8dec63cd3567f6a8 command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_1c8f7a80dd554273bfcc1d9051e41192(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_1c8f7a80dd554273bfcc1d9051e41192(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_1c8f7a80dd554273bfcc1d9051e41192(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_1c8f7a80dd554273bfcc1d9051e41192(_af37317ba36dc2e49a38df6db1a24aff_1c8f7a80dd554273bfcc1d9051e41192 command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_e9e4526a0c3743a0a9f392f99ad2dd45(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_e9e4526a0c3743a0a9f392f99ad2dd45(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_e9e4526a0c3743a0a9f392f99ad2dd45(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_e9e4526a0c3743a0a9f392f99ad2dd45(_af37317ba36dc2e49a38df6db1a24aff_e9e4526a0c3743a0a9f392f99ad2dd45 command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_9bce0cea735e4499afc5743bded21b40(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_9bce0cea735e4499afc5743bded21b40(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_9bce0cea735e4499afc5743bded21b40(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_9bce0cea735e4499afc5743bded21b40(_af37317ba36dc2e49a38df6db1a24aff_9bce0cea735e4499afc5743bded21b40 command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_021b12af921c470eafb1d9a772469f62(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_021b12af921c470eafb1d9a772469f62(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_021b12af921c470eafb1d9a772469f62(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_021b12af921c470eafb1d9a772469f62(_af37317ba36dc2e49a38df6db1a24aff_021b12af921c470eafb1d9a772469f62 command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_726d147cc96241c6881810002071c8f2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_726d147cc96241c6881810002071c8f2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_726d147cc96241c6881810002071c8f2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_726d147cc96241c6881810002071c8f2(_af37317ba36dc2e49a38df6db1a24aff_726d147cc96241c6881810002071c8f2 command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_8f607f38dd28493894e4b9eb0107149d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_8f607f38dd28493894e4b9eb0107149d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_8f607f38dd28493894e4b9eb0107149d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_8f607f38dd28493894e4b9eb0107149d(_af37317ba36dc2e49a38df6db1a24aff_8f607f38dd28493894e4b9eb0107149d command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_8a5a329e07c2414196a130a638044544(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_8a5a329e07c2414196a130a638044544(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_8a5a329e07c2414196a130a638044544(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_8a5a329e07c2414196a130a638044544(_af37317ba36dc2e49a38df6db1a24aff_8a5a329e07c2414196a130a638044544 command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_2eeef225630a4397bb35e411f3066f6e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_2eeef225630a4397bb35e411f3066f6e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_2eeef225630a4397bb35e411f3066f6e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_2eeef225630a4397bb35e411f3066f6e(_af37317ba36dc2e49a38df6db1a24aff_2eeef225630a4397bb35e411f3066f6e command)
		{
		}

		private void BakeCommandBinding__af37317ba36dc2e49a38df6db1a24aff_0219b742cf0e400b906f81738339f756(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af37317ba36dc2e49a38df6db1a24aff_0219b742cf0e400b906f81738339f756(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af37317ba36dc2e49a38df6db1a24aff_0219b742cf0e400b906f81738339f756(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af37317ba36dc2e49a38df6db1a24aff_0219b742cf0e400b906f81738339f756(_af37317ba36dc2e49a38df6db1a24aff_0219b742cf0e400b906f81738339f756 command)
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
