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
	public class CoherenceSync_0d7141adc7d8713458495f6487ff57b1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_5818172509824e959c71ba629f9a05a1_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_5fb6682f74634436a47e7e9d6704456f_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_d61ca5fa861049c19203d433055e3917_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_0e83d7597af247dcae9db147b7f62a2d_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_55729e132b3d42859b8ca908977d5d0b_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_1fcc27874a8c4ce09a4414bf67fad1cb_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_62960e103c9e45f3a1accbeb3b2e7c0b_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_d1bc4bc41817468790df071cb562f5b3_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_8ff04317de07446da83aaa689ce18f9c_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_6b39991045b54f0e86440e2ef9284c75_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_d45608f42ad54b299d2af7ae13b71145_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_a274737daa584e6984b8821425427226_CommandTarget;

		private CharacterController _0d7141adc7d8713458495f6487ff57b1_7beba4c801d8455796518411595333e5_CommandTarget;

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

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_5818172509824e959c71ba629f9a05a1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_5818172509824e959c71ba629f9a05a1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_5818172509824e959c71ba629f9a05a1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_5818172509824e959c71ba629f9a05a1(_0d7141adc7d8713458495f6487ff57b1_5818172509824e959c71ba629f9a05a1 command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_5fb6682f74634436a47e7e9d6704456f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_5fb6682f74634436a47e7e9d6704456f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_5fb6682f74634436a47e7e9d6704456f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_5fb6682f74634436a47e7e9d6704456f(_0d7141adc7d8713458495f6487ff57b1_5fb6682f74634436a47e7e9d6704456f command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_d61ca5fa861049c19203d433055e3917(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_d61ca5fa861049c19203d433055e3917(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_d61ca5fa861049c19203d433055e3917(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_d61ca5fa861049c19203d433055e3917(_0d7141adc7d8713458495f6487ff57b1_d61ca5fa861049c19203d433055e3917 command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_0e83d7597af247dcae9db147b7f62a2d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_0e83d7597af247dcae9db147b7f62a2d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_0e83d7597af247dcae9db147b7f62a2d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_0e83d7597af247dcae9db147b7f62a2d(_0d7141adc7d8713458495f6487ff57b1_0e83d7597af247dcae9db147b7f62a2d command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_55729e132b3d42859b8ca908977d5d0b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_55729e132b3d42859b8ca908977d5d0b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_55729e132b3d42859b8ca908977d5d0b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_55729e132b3d42859b8ca908977d5d0b(_0d7141adc7d8713458495f6487ff57b1_55729e132b3d42859b8ca908977d5d0b command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_1fcc27874a8c4ce09a4414bf67fad1cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_1fcc27874a8c4ce09a4414bf67fad1cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_1fcc27874a8c4ce09a4414bf67fad1cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_1fcc27874a8c4ce09a4414bf67fad1cb(_0d7141adc7d8713458495f6487ff57b1_1fcc27874a8c4ce09a4414bf67fad1cb command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_62960e103c9e45f3a1accbeb3b2e7c0b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_62960e103c9e45f3a1accbeb3b2e7c0b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_62960e103c9e45f3a1accbeb3b2e7c0b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_62960e103c9e45f3a1accbeb3b2e7c0b(_0d7141adc7d8713458495f6487ff57b1_62960e103c9e45f3a1accbeb3b2e7c0b command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_d1bc4bc41817468790df071cb562f5b3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_d1bc4bc41817468790df071cb562f5b3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_d1bc4bc41817468790df071cb562f5b3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_d1bc4bc41817468790df071cb562f5b3(_0d7141adc7d8713458495f6487ff57b1_d1bc4bc41817468790df071cb562f5b3 command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_8ff04317de07446da83aaa689ce18f9c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_8ff04317de07446da83aaa689ce18f9c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_8ff04317de07446da83aaa689ce18f9c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_8ff04317de07446da83aaa689ce18f9c(_0d7141adc7d8713458495f6487ff57b1_8ff04317de07446da83aaa689ce18f9c command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_6b39991045b54f0e86440e2ef9284c75(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_6b39991045b54f0e86440e2ef9284c75(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_6b39991045b54f0e86440e2ef9284c75(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_6b39991045b54f0e86440e2ef9284c75(_0d7141adc7d8713458495f6487ff57b1_6b39991045b54f0e86440e2ef9284c75 command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_d45608f42ad54b299d2af7ae13b71145(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_d45608f42ad54b299d2af7ae13b71145(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_d45608f42ad54b299d2af7ae13b71145(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_d45608f42ad54b299d2af7ae13b71145(_0d7141adc7d8713458495f6487ff57b1_d45608f42ad54b299d2af7ae13b71145 command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_a274737daa584e6984b8821425427226(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_a274737daa584e6984b8821425427226(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_a274737daa584e6984b8821425427226(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_a274737daa584e6984b8821425427226(_0d7141adc7d8713458495f6487ff57b1_a274737daa584e6984b8821425427226 command)
		{
		}

		private void BakeCommandBinding__0d7141adc7d8713458495f6487ff57b1_7beba4c801d8455796518411595333e5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0d7141adc7d8713458495f6487ff57b1_7beba4c801d8455796518411595333e5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0d7141adc7d8713458495f6487ff57b1_7beba4c801d8455796518411595333e5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0d7141adc7d8713458495f6487ff57b1_7beba4c801d8455796518411595333e5(_0d7141adc7d8713458495f6487ff57b1_7beba4c801d8455796518411595333e5 command)
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
