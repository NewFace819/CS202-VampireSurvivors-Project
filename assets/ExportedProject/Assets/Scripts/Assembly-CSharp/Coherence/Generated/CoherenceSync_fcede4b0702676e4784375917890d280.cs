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
	public class CoherenceSync_fcede4b0702676e4784375917890d280 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _fcede4b0702676e4784375917890d280_5ee8f140703b4079b6b622d213010385_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_82652600cb8d477cb66e3f7be6803331_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_69593c796fd8448499b25cf0436cb741_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_e379da61a46d4c52b2a52f2439a8509f_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_beb4c199c9df41f6819a9f1c39db5265_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_4289b83745754fc599abd5ebda25db77_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_6ee67435ff7d4f90b6faf2a01d74f4dc_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_cf9261b5ebe84f0cab80b4e0200a354b_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_18cbdd705e8e4ff4a1055d5bc994b724_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_4e241e6f940545639564c0b78628a7ae_CommandTarget;

		private TP_Blackmore_Character _fcede4b0702676e4784375917890d280_7578511fe5c042f7add0af31359486f5_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_7f8d044edce74cf9a5d49ee9b6710737_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_de97d20a876347c099adee4ac52c3f66_CommandTarget;

		private CharacterController _fcede4b0702676e4784375917890d280_9b2efa4c26d44c6d9b68ae1a470b6bc2_CommandTarget;

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

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_5ee8f140703b4079b6b622d213010385(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_5ee8f140703b4079b6b622d213010385(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_5ee8f140703b4079b6b622d213010385(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_5ee8f140703b4079b6b622d213010385(_fcede4b0702676e4784375917890d280_5ee8f140703b4079b6b622d213010385 command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_82652600cb8d477cb66e3f7be6803331(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_82652600cb8d477cb66e3f7be6803331(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_82652600cb8d477cb66e3f7be6803331(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_82652600cb8d477cb66e3f7be6803331(_fcede4b0702676e4784375917890d280_82652600cb8d477cb66e3f7be6803331 command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_69593c796fd8448499b25cf0436cb741(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_69593c796fd8448499b25cf0436cb741(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_69593c796fd8448499b25cf0436cb741(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_69593c796fd8448499b25cf0436cb741(_fcede4b0702676e4784375917890d280_69593c796fd8448499b25cf0436cb741 command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_e379da61a46d4c52b2a52f2439a8509f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_e379da61a46d4c52b2a52f2439a8509f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_e379da61a46d4c52b2a52f2439a8509f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_e379da61a46d4c52b2a52f2439a8509f(_fcede4b0702676e4784375917890d280_e379da61a46d4c52b2a52f2439a8509f command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_beb4c199c9df41f6819a9f1c39db5265(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_beb4c199c9df41f6819a9f1c39db5265(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_beb4c199c9df41f6819a9f1c39db5265(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_beb4c199c9df41f6819a9f1c39db5265(_fcede4b0702676e4784375917890d280_beb4c199c9df41f6819a9f1c39db5265 command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_4289b83745754fc599abd5ebda25db77(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_4289b83745754fc599abd5ebda25db77(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_4289b83745754fc599abd5ebda25db77(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_4289b83745754fc599abd5ebda25db77(_fcede4b0702676e4784375917890d280_4289b83745754fc599abd5ebda25db77 command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_6ee67435ff7d4f90b6faf2a01d74f4dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_6ee67435ff7d4f90b6faf2a01d74f4dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_6ee67435ff7d4f90b6faf2a01d74f4dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_6ee67435ff7d4f90b6faf2a01d74f4dc(_fcede4b0702676e4784375917890d280_6ee67435ff7d4f90b6faf2a01d74f4dc command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_cf9261b5ebe84f0cab80b4e0200a354b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_cf9261b5ebe84f0cab80b4e0200a354b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_cf9261b5ebe84f0cab80b4e0200a354b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_cf9261b5ebe84f0cab80b4e0200a354b(_fcede4b0702676e4784375917890d280_cf9261b5ebe84f0cab80b4e0200a354b command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_18cbdd705e8e4ff4a1055d5bc994b724(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_18cbdd705e8e4ff4a1055d5bc994b724(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_18cbdd705e8e4ff4a1055d5bc994b724(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_18cbdd705e8e4ff4a1055d5bc994b724(_fcede4b0702676e4784375917890d280_18cbdd705e8e4ff4a1055d5bc994b724 command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_4e241e6f940545639564c0b78628a7ae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_4e241e6f940545639564c0b78628a7ae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_4e241e6f940545639564c0b78628a7ae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_4e241e6f940545639564c0b78628a7ae(_fcede4b0702676e4784375917890d280_4e241e6f940545639564c0b78628a7ae command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_7578511fe5c042f7add0af31359486f5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_7578511fe5c042f7add0af31359486f5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_7578511fe5c042f7add0af31359486f5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_7578511fe5c042f7add0af31359486f5(_fcede4b0702676e4784375917890d280_7578511fe5c042f7add0af31359486f5 command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_7f8d044edce74cf9a5d49ee9b6710737(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_7f8d044edce74cf9a5d49ee9b6710737(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_7f8d044edce74cf9a5d49ee9b6710737(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_7f8d044edce74cf9a5d49ee9b6710737(_fcede4b0702676e4784375917890d280_7f8d044edce74cf9a5d49ee9b6710737 command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_de97d20a876347c099adee4ac52c3f66(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_de97d20a876347c099adee4ac52c3f66(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_de97d20a876347c099adee4ac52c3f66(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_de97d20a876347c099adee4ac52c3f66(_fcede4b0702676e4784375917890d280_de97d20a876347c099adee4ac52c3f66 command)
		{
		}

		private void BakeCommandBinding__fcede4b0702676e4784375917890d280_9b2efa4c26d44c6d9b68ae1a470b6bc2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcede4b0702676e4784375917890d280_9b2efa4c26d44c6d9b68ae1a470b6bc2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcede4b0702676e4784375917890d280_9b2efa4c26d44c6d9b68ae1a470b6bc2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcede4b0702676e4784375917890d280_9b2efa4c26d44c6d9b68ae1a470b6bc2(_fcede4b0702676e4784375917890d280_9b2efa4c26d44c6d9b68ae1a470b6bc2 command)
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
