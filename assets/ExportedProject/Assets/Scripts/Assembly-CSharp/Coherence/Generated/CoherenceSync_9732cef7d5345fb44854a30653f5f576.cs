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
	public class CoherenceSync_9732cef7d5345fb44854a30653f5f576 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_dff9e3ba72844ab0877e9bb15fe0c11d_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_1bb5a1d343ef4992b3f5b5bc8501594f_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_9bb390ad8cee4d198cee1f52d4689f2e_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_ce8401b905a9406e8cc3b9f432ed3df0_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_1fb99514770748f8a63dbb7f6aeab812_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_baade9825feb434ca12f12ac164b7b41_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_9a8241b83fbc4bb984cb014b18f28bb5_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_69d7f8a146394c6491b2f098d5b2ac62_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_3306a5b5e6a843759bd8e452f1b5f7eb_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_e06a42b39a97421cbfecdd61a4966c5b_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_b157983e20c14de88d3dc5801549713c_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_8f77b0f3e2a9492184bfd8dd63a5353b_CommandTarget;

		private CharacterController _9732cef7d5345fb44854a30653f5f576_b8bda0fc91b340ca80bbad36a4ba9178_CommandTarget;

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

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_dff9e3ba72844ab0877e9bb15fe0c11d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_dff9e3ba72844ab0877e9bb15fe0c11d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_dff9e3ba72844ab0877e9bb15fe0c11d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_dff9e3ba72844ab0877e9bb15fe0c11d(_9732cef7d5345fb44854a30653f5f576_dff9e3ba72844ab0877e9bb15fe0c11d command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_1bb5a1d343ef4992b3f5b5bc8501594f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_1bb5a1d343ef4992b3f5b5bc8501594f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_1bb5a1d343ef4992b3f5b5bc8501594f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_1bb5a1d343ef4992b3f5b5bc8501594f(_9732cef7d5345fb44854a30653f5f576_1bb5a1d343ef4992b3f5b5bc8501594f command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_9bb390ad8cee4d198cee1f52d4689f2e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_9bb390ad8cee4d198cee1f52d4689f2e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_9bb390ad8cee4d198cee1f52d4689f2e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_9bb390ad8cee4d198cee1f52d4689f2e(_9732cef7d5345fb44854a30653f5f576_9bb390ad8cee4d198cee1f52d4689f2e command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_ce8401b905a9406e8cc3b9f432ed3df0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_ce8401b905a9406e8cc3b9f432ed3df0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_ce8401b905a9406e8cc3b9f432ed3df0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_ce8401b905a9406e8cc3b9f432ed3df0(_9732cef7d5345fb44854a30653f5f576_ce8401b905a9406e8cc3b9f432ed3df0 command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_1fb99514770748f8a63dbb7f6aeab812(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_1fb99514770748f8a63dbb7f6aeab812(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_1fb99514770748f8a63dbb7f6aeab812(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_1fb99514770748f8a63dbb7f6aeab812(_9732cef7d5345fb44854a30653f5f576_1fb99514770748f8a63dbb7f6aeab812 command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_baade9825feb434ca12f12ac164b7b41(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_baade9825feb434ca12f12ac164b7b41(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_baade9825feb434ca12f12ac164b7b41(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_baade9825feb434ca12f12ac164b7b41(_9732cef7d5345fb44854a30653f5f576_baade9825feb434ca12f12ac164b7b41 command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_9a8241b83fbc4bb984cb014b18f28bb5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_9a8241b83fbc4bb984cb014b18f28bb5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_9a8241b83fbc4bb984cb014b18f28bb5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_9a8241b83fbc4bb984cb014b18f28bb5(_9732cef7d5345fb44854a30653f5f576_9a8241b83fbc4bb984cb014b18f28bb5 command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_69d7f8a146394c6491b2f098d5b2ac62(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_69d7f8a146394c6491b2f098d5b2ac62(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_69d7f8a146394c6491b2f098d5b2ac62(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_69d7f8a146394c6491b2f098d5b2ac62(_9732cef7d5345fb44854a30653f5f576_69d7f8a146394c6491b2f098d5b2ac62 command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_3306a5b5e6a843759bd8e452f1b5f7eb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_3306a5b5e6a843759bd8e452f1b5f7eb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_3306a5b5e6a843759bd8e452f1b5f7eb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_3306a5b5e6a843759bd8e452f1b5f7eb(_9732cef7d5345fb44854a30653f5f576_3306a5b5e6a843759bd8e452f1b5f7eb command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_e06a42b39a97421cbfecdd61a4966c5b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_e06a42b39a97421cbfecdd61a4966c5b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_e06a42b39a97421cbfecdd61a4966c5b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_e06a42b39a97421cbfecdd61a4966c5b(_9732cef7d5345fb44854a30653f5f576_e06a42b39a97421cbfecdd61a4966c5b command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_b157983e20c14de88d3dc5801549713c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_b157983e20c14de88d3dc5801549713c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_b157983e20c14de88d3dc5801549713c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_b157983e20c14de88d3dc5801549713c(_9732cef7d5345fb44854a30653f5f576_b157983e20c14de88d3dc5801549713c command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_8f77b0f3e2a9492184bfd8dd63a5353b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_8f77b0f3e2a9492184bfd8dd63a5353b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_8f77b0f3e2a9492184bfd8dd63a5353b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_8f77b0f3e2a9492184bfd8dd63a5353b(_9732cef7d5345fb44854a30653f5f576_8f77b0f3e2a9492184bfd8dd63a5353b command)
		{
		}

		private void BakeCommandBinding__9732cef7d5345fb44854a30653f5f576_b8bda0fc91b340ca80bbad36a4ba9178(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9732cef7d5345fb44854a30653f5f576_b8bda0fc91b340ca80bbad36a4ba9178(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9732cef7d5345fb44854a30653f5f576_b8bda0fc91b340ca80bbad36a4ba9178(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9732cef7d5345fb44854a30653f5f576_b8bda0fc91b340ca80bbad36a4ba9178(_9732cef7d5345fb44854a30653f5f576_b8bda0fc91b340ca80bbad36a4ba9178 command)
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
