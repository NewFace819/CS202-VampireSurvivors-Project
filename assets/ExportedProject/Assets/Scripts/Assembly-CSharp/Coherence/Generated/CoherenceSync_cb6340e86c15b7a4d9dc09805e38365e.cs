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
	public class CoherenceSync_cb6340e86c15b7a4d9dc09805e38365e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_6df1e9d5f05141209f6e46cfffb1e605_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_8488636b61f04821af071db4ae361f13_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_354dff125ca74b788aee65091831bb1a_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_25205b1088bc488aadb956285e37e7a6_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_62c19847d01f492695caba705fa4dada_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_f01e98cfc5c3454f8f38ad12a63350b7_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_195f98aec94148fe9a19432a79031c77_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_34ad7843c627447e97c96946c6b7a281_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_d8c6fb71387d4dd6931298d9d7a3a28e_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_89a2253c46d44000917b6f4bb609c50a_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_d18d894da5ea49329d49dcb16bc1e281_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_41952c7a74f54a3e8fb52824d9ec1d4a_CommandTarget;

		private CharacterController _cb6340e86c15b7a4d9dc09805e38365e_9e80bc07d6cd472ba6494fc80798d9af_CommandTarget;

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

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_6df1e9d5f05141209f6e46cfffb1e605(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_6df1e9d5f05141209f6e46cfffb1e605(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_6df1e9d5f05141209f6e46cfffb1e605(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_6df1e9d5f05141209f6e46cfffb1e605(_cb6340e86c15b7a4d9dc09805e38365e_6df1e9d5f05141209f6e46cfffb1e605 command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_8488636b61f04821af071db4ae361f13(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_8488636b61f04821af071db4ae361f13(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_8488636b61f04821af071db4ae361f13(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_8488636b61f04821af071db4ae361f13(_cb6340e86c15b7a4d9dc09805e38365e_8488636b61f04821af071db4ae361f13 command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_354dff125ca74b788aee65091831bb1a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_354dff125ca74b788aee65091831bb1a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_354dff125ca74b788aee65091831bb1a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_354dff125ca74b788aee65091831bb1a(_cb6340e86c15b7a4d9dc09805e38365e_354dff125ca74b788aee65091831bb1a command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_25205b1088bc488aadb956285e37e7a6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_25205b1088bc488aadb956285e37e7a6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_25205b1088bc488aadb956285e37e7a6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_25205b1088bc488aadb956285e37e7a6(_cb6340e86c15b7a4d9dc09805e38365e_25205b1088bc488aadb956285e37e7a6 command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_62c19847d01f492695caba705fa4dada(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_62c19847d01f492695caba705fa4dada(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_62c19847d01f492695caba705fa4dada(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_62c19847d01f492695caba705fa4dada(_cb6340e86c15b7a4d9dc09805e38365e_62c19847d01f492695caba705fa4dada command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_f01e98cfc5c3454f8f38ad12a63350b7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_f01e98cfc5c3454f8f38ad12a63350b7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_f01e98cfc5c3454f8f38ad12a63350b7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_f01e98cfc5c3454f8f38ad12a63350b7(_cb6340e86c15b7a4d9dc09805e38365e_f01e98cfc5c3454f8f38ad12a63350b7 command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_195f98aec94148fe9a19432a79031c77(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_195f98aec94148fe9a19432a79031c77(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_195f98aec94148fe9a19432a79031c77(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_195f98aec94148fe9a19432a79031c77(_cb6340e86c15b7a4d9dc09805e38365e_195f98aec94148fe9a19432a79031c77 command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_34ad7843c627447e97c96946c6b7a281(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_34ad7843c627447e97c96946c6b7a281(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_34ad7843c627447e97c96946c6b7a281(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_34ad7843c627447e97c96946c6b7a281(_cb6340e86c15b7a4d9dc09805e38365e_34ad7843c627447e97c96946c6b7a281 command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_d8c6fb71387d4dd6931298d9d7a3a28e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_d8c6fb71387d4dd6931298d9d7a3a28e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_d8c6fb71387d4dd6931298d9d7a3a28e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_d8c6fb71387d4dd6931298d9d7a3a28e(_cb6340e86c15b7a4d9dc09805e38365e_d8c6fb71387d4dd6931298d9d7a3a28e command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_89a2253c46d44000917b6f4bb609c50a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_89a2253c46d44000917b6f4bb609c50a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_89a2253c46d44000917b6f4bb609c50a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_89a2253c46d44000917b6f4bb609c50a(_cb6340e86c15b7a4d9dc09805e38365e_89a2253c46d44000917b6f4bb609c50a command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_d18d894da5ea49329d49dcb16bc1e281(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_d18d894da5ea49329d49dcb16bc1e281(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_d18d894da5ea49329d49dcb16bc1e281(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_d18d894da5ea49329d49dcb16bc1e281(_cb6340e86c15b7a4d9dc09805e38365e_d18d894da5ea49329d49dcb16bc1e281 command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_41952c7a74f54a3e8fb52824d9ec1d4a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_41952c7a74f54a3e8fb52824d9ec1d4a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_41952c7a74f54a3e8fb52824d9ec1d4a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_41952c7a74f54a3e8fb52824d9ec1d4a(_cb6340e86c15b7a4d9dc09805e38365e_41952c7a74f54a3e8fb52824d9ec1d4a command)
		{
		}

		private void BakeCommandBinding__cb6340e86c15b7a4d9dc09805e38365e_9e80bc07d6cd472ba6494fc80798d9af(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cb6340e86c15b7a4d9dc09805e38365e_9e80bc07d6cd472ba6494fc80798d9af(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cb6340e86c15b7a4d9dc09805e38365e_9e80bc07d6cd472ba6494fc80798d9af(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cb6340e86c15b7a4d9dc09805e38365e_9e80bc07d6cd472ba6494fc80798d9af(_cb6340e86c15b7a4d9dc09805e38365e_9e80bc07d6cd472ba6494fc80798d9af command)
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
