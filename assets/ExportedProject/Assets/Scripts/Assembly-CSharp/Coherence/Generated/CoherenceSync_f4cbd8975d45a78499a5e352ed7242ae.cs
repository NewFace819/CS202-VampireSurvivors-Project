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
	public class CoherenceSync_f4cbd8975d45a78499a5e352ed7242ae : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_a77ff63a43eb4e189bfa05956ec43c9f_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_3d5870020ac9407ead56329bf38e3c95_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_43e0958b83a847c09f2082ca7ad9a0dc_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_7a4d0a86d4b94fb0839918854f33e24a_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_81a56dd09da545ab923f21cf10f4916a_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_5ed7c75ea1b147dea1aee578a850be39_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_febe99e0cc544707bd06bb7cedb3319f_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_8f7fbd6635db41358a8c507d424aecbf_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_303ad56e89f64acabfa6eaf56ef73306_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_1b0d540d6d2d4e5e984bd500c6567ddc_CommandTarget;

		private TP_Olrox_Character _f4cbd8975d45a78499a5e352ed7242ae_0e0c1b4863e044a5af8b70a58c86e136_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_d4408d43dd8b40fcbbc80cf876b5b970_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_e52bfe6fba7245ed82c225966ac29c8a_CommandTarget;

		private CharacterController _f4cbd8975d45a78499a5e352ed7242ae_d07b68ccb48e40408bb4534fb717effc_CommandTarget;

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

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_a77ff63a43eb4e189bfa05956ec43c9f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_a77ff63a43eb4e189bfa05956ec43c9f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_a77ff63a43eb4e189bfa05956ec43c9f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_a77ff63a43eb4e189bfa05956ec43c9f(_f4cbd8975d45a78499a5e352ed7242ae_a77ff63a43eb4e189bfa05956ec43c9f command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_3d5870020ac9407ead56329bf38e3c95(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_3d5870020ac9407ead56329bf38e3c95(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_3d5870020ac9407ead56329bf38e3c95(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_3d5870020ac9407ead56329bf38e3c95(_f4cbd8975d45a78499a5e352ed7242ae_3d5870020ac9407ead56329bf38e3c95 command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_43e0958b83a847c09f2082ca7ad9a0dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_43e0958b83a847c09f2082ca7ad9a0dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_43e0958b83a847c09f2082ca7ad9a0dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_43e0958b83a847c09f2082ca7ad9a0dc(_f4cbd8975d45a78499a5e352ed7242ae_43e0958b83a847c09f2082ca7ad9a0dc command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_7a4d0a86d4b94fb0839918854f33e24a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_7a4d0a86d4b94fb0839918854f33e24a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_7a4d0a86d4b94fb0839918854f33e24a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_7a4d0a86d4b94fb0839918854f33e24a(_f4cbd8975d45a78499a5e352ed7242ae_7a4d0a86d4b94fb0839918854f33e24a command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_81a56dd09da545ab923f21cf10f4916a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_81a56dd09da545ab923f21cf10f4916a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_81a56dd09da545ab923f21cf10f4916a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_81a56dd09da545ab923f21cf10f4916a(_f4cbd8975d45a78499a5e352ed7242ae_81a56dd09da545ab923f21cf10f4916a command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_5ed7c75ea1b147dea1aee578a850be39(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_5ed7c75ea1b147dea1aee578a850be39(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_5ed7c75ea1b147dea1aee578a850be39(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_5ed7c75ea1b147dea1aee578a850be39(_f4cbd8975d45a78499a5e352ed7242ae_5ed7c75ea1b147dea1aee578a850be39 command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_febe99e0cc544707bd06bb7cedb3319f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_febe99e0cc544707bd06bb7cedb3319f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_febe99e0cc544707bd06bb7cedb3319f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_febe99e0cc544707bd06bb7cedb3319f(_f4cbd8975d45a78499a5e352ed7242ae_febe99e0cc544707bd06bb7cedb3319f command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_8f7fbd6635db41358a8c507d424aecbf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_8f7fbd6635db41358a8c507d424aecbf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_8f7fbd6635db41358a8c507d424aecbf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_8f7fbd6635db41358a8c507d424aecbf(_f4cbd8975d45a78499a5e352ed7242ae_8f7fbd6635db41358a8c507d424aecbf command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_303ad56e89f64acabfa6eaf56ef73306(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_303ad56e89f64acabfa6eaf56ef73306(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_303ad56e89f64acabfa6eaf56ef73306(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_303ad56e89f64acabfa6eaf56ef73306(_f4cbd8975d45a78499a5e352ed7242ae_303ad56e89f64acabfa6eaf56ef73306 command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_1b0d540d6d2d4e5e984bd500c6567ddc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_1b0d540d6d2d4e5e984bd500c6567ddc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_1b0d540d6d2d4e5e984bd500c6567ddc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_1b0d540d6d2d4e5e984bd500c6567ddc(_f4cbd8975d45a78499a5e352ed7242ae_1b0d540d6d2d4e5e984bd500c6567ddc command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_0e0c1b4863e044a5af8b70a58c86e136(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_0e0c1b4863e044a5af8b70a58c86e136(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_0e0c1b4863e044a5af8b70a58c86e136(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_0e0c1b4863e044a5af8b70a58c86e136(_f4cbd8975d45a78499a5e352ed7242ae_0e0c1b4863e044a5af8b70a58c86e136 command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_d4408d43dd8b40fcbbc80cf876b5b970(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_d4408d43dd8b40fcbbc80cf876b5b970(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_d4408d43dd8b40fcbbc80cf876b5b970(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_d4408d43dd8b40fcbbc80cf876b5b970(_f4cbd8975d45a78499a5e352ed7242ae_d4408d43dd8b40fcbbc80cf876b5b970 command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_e52bfe6fba7245ed82c225966ac29c8a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_e52bfe6fba7245ed82c225966ac29c8a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_e52bfe6fba7245ed82c225966ac29c8a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_e52bfe6fba7245ed82c225966ac29c8a(_f4cbd8975d45a78499a5e352ed7242ae_e52bfe6fba7245ed82c225966ac29c8a command)
		{
		}

		private void BakeCommandBinding__f4cbd8975d45a78499a5e352ed7242ae_d07b68ccb48e40408bb4534fb717effc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f4cbd8975d45a78499a5e352ed7242ae_d07b68ccb48e40408bb4534fb717effc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f4cbd8975d45a78499a5e352ed7242ae_d07b68ccb48e40408bb4534fb717effc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f4cbd8975d45a78499a5e352ed7242ae_d07b68ccb48e40408bb4534fb717effc(_f4cbd8975d45a78499a5e352ed7242ae_d07b68ccb48e40408bb4534fb717effc command)
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
