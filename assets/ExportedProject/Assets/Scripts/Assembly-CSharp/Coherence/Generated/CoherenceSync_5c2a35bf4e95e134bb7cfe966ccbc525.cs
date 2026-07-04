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
	public class CoherenceSync_5c2a35bf4e95e134bb7cfe966ccbc525 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_7e14e712cb7b4c1dbc92843dd59e9780_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_61d7c148e49048ceac3ea571a89d1c24_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_b05ab84d50c74f1daedf51b02548244e_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_ace771bb95da4258987600ab6de545e6_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_53386af4296f435c9ef764e28158edda_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_546b042401a948b5be292bc4b398c1fb_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_6d00e4ecd6dd408ab64ccbf17d0a5965_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_51f833845f1142339ad7039122a8505f_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_236c817d3725449fa259108a120f0ed7_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_c102ad789973431ca354dbaf769b99de_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_f454c084e30f4335be2d4642013ade0e_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_763dad9d1e8b4b67ad2213844d9a63c6_CommandTarget;

		private CharacterController _5c2a35bf4e95e134bb7cfe966ccbc525_e2a01066fcc4494a85cd18c22aab83de_CommandTarget;

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

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_7e14e712cb7b4c1dbc92843dd59e9780(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_7e14e712cb7b4c1dbc92843dd59e9780(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_7e14e712cb7b4c1dbc92843dd59e9780(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_7e14e712cb7b4c1dbc92843dd59e9780(_5c2a35bf4e95e134bb7cfe966ccbc525_7e14e712cb7b4c1dbc92843dd59e9780 command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_61d7c148e49048ceac3ea571a89d1c24(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_61d7c148e49048ceac3ea571a89d1c24(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_61d7c148e49048ceac3ea571a89d1c24(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_61d7c148e49048ceac3ea571a89d1c24(_5c2a35bf4e95e134bb7cfe966ccbc525_61d7c148e49048ceac3ea571a89d1c24 command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_b05ab84d50c74f1daedf51b02548244e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_b05ab84d50c74f1daedf51b02548244e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_b05ab84d50c74f1daedf51b02548244e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_b05ab84d50c74f1daedf51b02548244e(_5c2a35bf4e95e134bb7cfe966ccbc525_b05ab84d50c74f1daedf51b02548244e command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_ace771bb95da4258987600ab6de545e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_ace771bb95da4258987600ab6de545e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_ace771bb95da4258987600ab6de545e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_ace771bb95da4258987600ab6de545e6(_5c2a35bf4e95e134bb7cfe966ccbc525_ace771bb95da4258987600ab6de545e6 command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_53386af4296f435c9ef764e28158edda(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_53386af4296f435c9ef764e28158edda(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_53386af4296f435c9ef764e28158edda(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_53386af4296f435c9ef764e28158edda(_5c2a35bf4e95e134bb7cfe966ccbc525_53386af4296f435c9ef764e28158edda command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_546b042401a948b5be292bc4b398c1fb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_546b042401a948b5be292bc4b398c1fb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_546b042401a948b5be292bc4b398c1fb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_546b042401a948b5be292bc4b398c1fb(_5c2a35bf4e95e134bb7cfe966ccbc525_546b042401a948b5be292bc4b398c1fb command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_6d00e4ecd6dd408ab64ccbf17d0a5965(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_6d00e4ecd6dd408ab64ccbf17d0a5965(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_6d00e4ecd6dd408ab64ccbf17d0a5965(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_6d00e4ecd6dd408ab64ccbf17d0a5965(_5c2a35bf4e95e134bb7cfe966ccbc525_6d00e4ecd6dd408ab64ccbf17d0a5965 command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_51f833845f1142339ad7039122a8505f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_51f833845f1142339ad7039122a8505f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_51f833845f1142339ad7039122a8505f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_51f833845f1142339ad7039122a8505f(_5c2a35bf4e95e134bb7cfe966ccbc525_51f833845f1142339ad7039122a8505f command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_236c817d3725449fa259108a120f0ed7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_236c817d3725449fa259108a120f0ed7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_236c817d3725449fa259108a120f0ed7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_236c817d3725449fa259108a120f0ed7(_5c2a35bf4e95e134bb7cfe966ccbc525_236c817d3725449fa259108a120f0ed7 command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_c102ad789973431ca354dbaf769b99de(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_c102ad789973431ca354dbaf769b99de(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_c102ad789973431ca354dbaf769b99de(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_c102ad789973431ca354dbaf769b99de(_5c2a35bf4e95e134bb7cfe966ccbc525_c102ad789973431ca354dbaf769b99de command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_f454c084e30f4335be2d4642013ade0e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_f454c084e30f4335be2d4642013ade0e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_f454c084e30f4335be2d4642013ade0e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_f454c084e30f4335be2d4642013ade0e(_5c2a35bf4e95e134bb7cfe966ccbc525_f454c084e30f4335be2d4642013ade0e command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_763dad9d1e8b4b67ad2213844d9a63c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_763dad9d1e8b4b67ad2213844d9a63c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_763dad9d1e8b4b67ad2213844d9a63c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_763dad9d1e8b4b67ad2213844d9a63c6(_5c2a35bf4e95e134bb7cfe966ccbc525_763dad9d1e8b4b67ad2213844d9a63c6 command)
		{
		}

		private void BakeCommandBinding__5c2a35bf4e95e134bb7cfe966ccbc525_e2a01066fcc4494a85cd18c22aab83de(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c2a35bf4e95e134bb7cfe966ccbc525_e2a01066fcc4494a85cd18c22aab83de(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c2a35bf4e95e134bb7cfe966ccbc525_e2a01066fcc4494a85cd18c22aab83de(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c2a35bf4e95e134bb7cfe966ccbc525_e2a01066fcc4494a85cd18c22aab83de(_5c2a35bf4e95e134bb7cfe966ccbc525_e2a01066fcc4494a85cd18c22aab83de command)
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
