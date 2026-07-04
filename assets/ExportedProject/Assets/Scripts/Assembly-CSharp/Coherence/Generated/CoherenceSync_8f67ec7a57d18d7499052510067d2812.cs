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
	public class CoherenceSync_8f67ec7a57d18d7499052510067d2812 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_66e55277f178468db222ead62464fabc_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_4d75d927696b49349368f2cc0d398ecc_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_379dadcb69fa4bcfa78e55e40c9f0007_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_fb95c12b1ee64985bbac87cb65d8009e_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_680dc0d63a914c73b362de65580b07dd_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_abd86b9991b8428dafd88a4c8fc71005_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_732d4da4169f475397f6ee50ff3f7351_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_d4c84186ac7f425baec00305a77195b6_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_734ef5bf42ec49f091cf2cd4690d0951_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_307d9d64d283496eb4f37c5cbd67a232_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_53092e7962df405a99583ee030842c8d_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_7721f440f39d41d890954b0c878df1fd_CommandTarget;

		private CharacterController _8f67ec7a57d18d7499052510067d2812_d7492194e43d42a898c0dcf35973e6ea_CommandTarget;

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

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_66e55277f178468db222ead62464fabc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_66e55277f178468db222ead62464fabc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_66e55277f178468db222ead62464fabc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_66e55277f178468db222ead62464fabc(_8f67ec7a57d18d7499052510067d2812_66e55277f178468db222ead62464fabc command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_4d75d927696b49349368f2cc0d398ecc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_4d75d927696b49349368f2cc0d398ecc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_4d75d927696b49349368f2cc0d398ecc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_4d75d927696b49349368f2cc0d398ecc(_8f67ec7a57d18d7499052510067d2812_4d75d927696b49349368f2cc0d398ecc command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_379dadcb69fa4bcfa78e55e40c9f0007(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_379dadcb69fa4bcfa78e55e40c9f0007(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_379dadcb69fa4bcfa78e55e40c9f0007(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_379dadcb69fa4bcfa78e55e40c9f0007(_8f67ec7a57d18d7499052510067d2812_379dadcb69fa4bcfa78e55e40c9f0007 command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_fb95c12b1ee64985bbac87cb65d8009e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_fb95c12b1ee64985bbac87cb65d8009e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_fb95c12b1ee64985bbac87cb65d8009e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_fb95c12b1ee64985bbac87cb65d8009e(_8f67ec7a57d18d7499052510067d2812_fb95c12b1ee64985bbac87cb65d8009e command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_680dc0d63a914c73b362de65580b07dd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_680dc0d63a914c73b362de65580b07dd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_680dc0d63a914c73b362de65580b07dd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_680dc0d63a914c73b362de65580b07dd(_8f67ec7a57d18d7499052510067d2812_680dc0d63a914c73b362de65580b07dd command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_abd86b9991b8428dafd88a4c8fc71005(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_abd86b9991b8428dafd88a4c8fc71005(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_abd86b9991b8428dafd88a4c8fc71005(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_abd86b9991b8428dafd88a4c8fc71005(_8f67ec7a57d18d7499052510067d2812_abd86b9991b8428dafd88a4c8fc71005 command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_732d4da4169f475397f6ee50ff3f7351(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_732d4da4169f475397f6ee50ff3f7351(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_732d4da4169f475397f6ee50ff3f7351(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_732d4da4169f475397f6ee50ff3f7351(_8f67ec7a57d18d7499052510067d2812_732d4da4169f475397f6ee50ff3f7351 command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_d4c84186ac7f425baec00305a77195b6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_d4c84186ac7f425baec00305a77195b6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_d4c84186ac7f425baec00305a77195b6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_d4c84186ac7f425baec00305a77195b6(_8f67ec7a57d18d7499052510067d2812_d4c84186ac7f425baec00305a77195b6 command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_734ef5bf42ec49f091cf2cd4690d0951(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_734ef5bf42ec49f091cf2cd4690d0951(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_734ef5bf42ec49f091cf2cd4690d0951(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_734ef5bf42ec49f091cf2cd4690d0951(_8f67ec7a57d18d7499052510067d2812_734ef5bf42ec49f091cf2cd4690d0951 command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_307d9d64d283496eb4f37c5cbd67a232(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_307d9d64d283496eb4f37c5cbd67a232(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_307d9d64d283496eb4f37c5cbd67a232(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_307d9d64d283496eb4f37c5cbd67a232(_8f67ec7a57d18d7499052510067d2812_307d9d64d283496eb4f37c5cbd67a232 command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_53092e7962df405a99583ee030842c8d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_53092e7962df405a99583ee030842c8d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_53092e7962df405a99583ee030842c8d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_53092e7962df405a99583ee030842c8d(_8f67ec7a57d18d7499052510067d2812_53092e7962df405a99583ee030842c8d command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_7721f440f39d41d890954b0c878df1fd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_7721f440f39d41d890954b0c878df1fd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_7721f440f39d41d890954b0c878df1fd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_7721f440f39d41d890954b0c878df1fd(_8f67ec7a57d18d7499052510067d2812_7721f440f39d41d890954b0c878df1fd command)
		{
		}

		private void BakeCommandBinding__8f67ec7a57d18d7499052510067d2812_d7492194e43d42a898c0dcf35973e6ea(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f67ec7a57d18d7499052510067d2812_d7492194e43d42a898c0dcf35973e6ea(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f67ec7a57d18d7499052510067d2812_d7492194e43d42a898c0dcf35973e6ea(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f67ec7a57d18d7499052510067d2812_d7492194e43d42a898c0dcf35973e6ea(_8f67ec7a57d18d7499052510067d2812_d7492194e43d42a898c0dcf35973e6ea command)
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
