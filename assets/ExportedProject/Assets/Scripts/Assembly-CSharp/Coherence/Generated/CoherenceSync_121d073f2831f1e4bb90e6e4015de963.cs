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
	public class CoherenceSync_121d073f2831f1e4bb90e6e4015de963 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_63c24f8f0eec492e870d3d76537d52be_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_01f3191421924bffad638662f64194c7_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_2b14c8a8d99444b69d8999062ef6fd01_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_e237d8699b2044918e48783e51a5a666_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_6316e11b8ce44661855ac7ce2e357844_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_156f7856eae141699c59961310c78410_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_87bc518abf54488eaff954839de397bb_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_82d26ffef8a24c4483ba607ff09f0d03_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_a9d74fb43553477991b4cfb25545062c_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_460d5e0024454464a4f14991e0a8a5ea_CommandTarget;

		private TP_Joachim_Character _121d073f2831f1e4bb90e6e4015de963_8c5253cfcf904c8f957c7c6044a9801f_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_0bd2d0f830fa43f6854a9550e945bea1_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_06ddd1545c1843deb8c97d56094f0a05_CommandTarget;

		private CharacterController _121d073f2831f1e4bb90e6e4015de963_2ef090c4f90c4dd1b98545d10ab5372f_CommandTarget;

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

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_63c24f8f0eec492e870d3d76537d52be(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_63c24f8f0eec492e870d3d76537d52be(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_63c24f8f0eec492e870d3d76537d52be(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_63c24f8f0eec492e870d3d76537d52be(_121d073f2831f1e4bb90e6e4015de963_63c24f8f0eec492e870d3d76537d52be command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_01f3191421924bffad638662f64194c7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_01f3191421924bffad638662f64194c7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_01f3191421924bffad638662f64194c7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_01f3191421924bffad638662f64194c7(_121d073f2831f1e4bb90e6e4015de963_01f3191421924bffad638662f64194c7 command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_2b14c8a8d99444b69d8999062ef6fd01(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_2b14c8a8d99444b69d8999062ef6fd01(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_2b14c8a8d99444b69d8999062ef6fd01(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_2b14c8a8d99444b69d8999062ef6fd01(_121d073f2831f1e4bb90e6e4015de963_2b14c8a8d99444b69d8999062ef6fd01 command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_e237d8699b2044918e48783e51a5a666(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_e237d8699b2044918e48783e51a5a666(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_e237d8699b2044918e48783e51a5a666(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_e237d8699b2044918e48783e51a5a666(_121d073f2831f1e4bb90e6e4015de963_e237d8699b2044918e48783e51a5a666 command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_6316e11b8ce44661855ac7ce2e357844(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_6316e11b8ce44661855ac7ce2e357844(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_6316e11b8ce44661855ac7ce2e357844(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_6316e11b8ce44661855ac7ce2e357844(_121d073f2831f1e4bb90e6e4015de963_6316e11b8ce44661855ac7ce2e357844 command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_156f7856eae141699c59961310c78410(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_156f7856eae141699c59961310c78410(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_156f7856eae141699c59961310c78410(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_156f7856eae141699c59961310c78410(_121d073f2831f1e4bb90e6e4015de963_156f7856eae141699c59961310c78410 command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_87bc518abf54488eaff954839de397bb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_87bc518abf54488eaff954839de397bb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_87bc518abf54488eaff954839de397bb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_87bc518abf54488eaff954839de397bb(_121d073f2831f1e4bb90e6e4015de963_87bc518abf54488eaff954839de397bb command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_82d26ffef8a24c4483ba607ff09f0d03(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_82d26ffef8a24c4483ba607ff09f0d03(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_82d26ffef8a24c4483ba607ff09f0d03(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_82d26ffef8a24c4483ba607ff09f0d03(_121d073f2831f1e4bb90e6e4015de963_82d26ffef8a24c4483ba607ff09f0d03 command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_a9d74fb43553477991b4cfb25545062c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_a9d74fb43553477991b4cfb25545062c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_a9d74fb43553477991b4cfb25545062c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_a9d74fb43553477991b4cfb25545062c(_121d073f2831f1e4bb90e6e4015de963_a9d74fb43553477991b4cfb25545062c command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_460d5e0024454464a4f14991e0a8a5ea(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_460d5e0024454464a4f14991e0a8a5ea(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_460d5e0024454464a4f14991e0a8a5ea(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_460d5e0024454464a4f14991e0a8a5ea(_121d073f2831f1e4bb90e6e4015de963_460d5e0024454464a4f14991e0a8a5ea command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_8c5253cfcf904c8f957c7c6044a9801f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_8c5253cfcf904c8f957c7c6044a9801f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_8c5253cfcf904c8f957c7c6044a9801f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_8c5253cfcf904c8f957c7c6044a9801f(_121d073f2831f1e4bb90e6e4015de963_8c5253cfcf904c8f957c7c6044a9801f command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_0bd2d0f830fa43f6854a9550e945bea1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_0bd2d0f830fa43f6854a9550e945bea1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_0bd2d0f830fa43f6854a9550e945bea1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_0bd2d0f830fa43f6854a9550e945bea1(_121d073f2831f1e4bb90e6e4015de963_0bd2d0f830fa43f6854a9550e945bea1 command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_06ddd1545c1843deb8c97d56094f0a05(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_06ddd1545c1843deb8c97d56094f0a05(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_06ddd1545c1843deb8c97d56094f0a05(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_06ddd1545c1843deb8c97d56094f0a05(_121d073f2831f1e4bb90e6e4015de963_06ddd1545c1843deb8c97d56094f0a05 command)
		{
		}

		private void BakeCommandBinding__121d073f2831f1e4bb90e6e4015de963_2ef090c4f90c4dd1b98545d10ab5372f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__121d073f2831f1e4bb90e6e4015de963_2ef090c4f90c4dd1b98545d10ab5372f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__121d073f2831f1e4bb90e6e4015de963_2ef090c4f90c4dd1b98545d10ab5372f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__121d073f2831f1e4bb90e6e4015de963_2ef090c4f90c4dd1b98545d10ab5372f(_121d073f2831f1e4bb90e6e4015de963_2ef090c4f90c4dd1b98545d10ab5372f command)
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
