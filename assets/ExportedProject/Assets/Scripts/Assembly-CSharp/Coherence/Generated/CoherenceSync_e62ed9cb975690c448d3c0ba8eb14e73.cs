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
	public class CoherenceSync_e62ed9cb975690c448d3c0ba8eb14e73 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_dee3efa636e44e768280034a2299121f_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_2e95675da4d14b07b4ca0a613b253b78_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_700a68f0f1614defb56ebb576ece6bf5_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_0602aaf6e8f145a295b3e50a6a8599a1_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_fadb8f5fbf4c44a0a4167375afb0fc3c_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_404a1c5dc45c43f6b81b3729f4e47e97_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_ba70e6d963654b76a446dd9981ea6d0c_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_b7c6d52649b1412797902f1b8fd34135_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_f56e5177938b409387583f29649ff233_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_38cdcd0693454eb0a911f2f35bda4453_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_79b464d6bf3c4c56ad97c27f9b0fb42c_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_220113f4c1424f5da9a300277e77eaa7_CommandTarget;

		private CharacterController _e62ed9cb975690c448d3c0ba8eb14e73_eb37f76457f64f48b819a77366201968_CommandTarget;

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

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_dee3efa636e44e768280034a2299121f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_dee3efa636e44e768280034a2299121f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_dee3efa636e44e768280034a2299121f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_dee3efa636e44e768280034a2299121f(_e62ed9cb975690c448d3c0ba8eb14e73_dee3efa636e44e768280034a2299121f command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_2e95675da4d14b07b4ca0a613b253b78(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_2e95675da4d14b07b4ca0a613b253b78(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_2e95675da4d14b07b4ca0a613b253b78(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_2e95675da4d14b07b4ca0a613b253b78(_e62ed9cb975690c448d3c0ba8eb14e73_2e95675da4d14b07b4ca0a613b253b78 command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_700a68f0f1614defb56ebb576ece6bf5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_700a68f0f1614defb56ebb576ece6bf5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_700a68f0f1614defb56ebb576ece6bf5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_700a68f0f1614defb56ebb576ece6bf5(_e62ed9cb975690c448d3c0ba8eb14e73_700a68f0f1614defb56ebb576ece6bf5 command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_0602aaf6e8f145a295b3e50a6a8599a1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_0602aaf6e8f145a295b3e50a6a8599a1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_0602aaf6e8f145a295b3e50a6a8599a1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_0602aaf6e8f145a295b3e50a6a8599a1(_e62ed9cb975690c448d3c0ba8eb14e73_0602aaf6e8f145a295b3e50a6a8599a1 command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_fadb8f5fbf4c44a0a4167375afb0fc3c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_fadb8f5fbf4c44a0a4167375afb0fc3c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_fadb8f5fbf4c44a0a4167375afb0fc3c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_fadb8f5fbf4c44a0a4167375afb0fc3c(_e62ed9cb975690c448d3c0ba8eb14e73_fadb8f5fbf4c44a0a4167375afb0fc3c command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_404a1c5dc45c43f6b81b3729f4e47e97(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_404a1c5dc45c43f6b81b3729f4e47e97(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_404a1c5dc45c43f6b81b3729f4e47e97(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_404a1c5dc45c43f6b81b3729f4e47e97(_e62ed9cb975690c448d3c0ba8eb14e73_404a1c5dc45c43f6b81b3729f4e47e97 command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_ba70e6d963654b76a446dd9981ea6d0c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_ba70e6d963654b76a446dd9981ea6d0c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_ba70e6d963654b76a446dd9981ea6d0c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_ba70e6d963654b76a446dd9981ea6d0c(_e62ed9cb975690c448d3c0ba8eb14e73_ba70e6d963654b76a446dd9981ea6d0c command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_b7c6d52649b1412797902f1b8fd34135(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_b7c6d52649b1412797902f1b8fd34135(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_b7c6d52649b1412797902f1b8fd34135(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_b7c6d52649b1412797902f1b8fd34135(_e62ed9cb975690c448d3c0ba8eb14e73_b7c6d52649b1412797902f1b8fd34135 command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_f56e5177938b409387583f29649ff233(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_f56e5177938b409387583f29649ff233(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_f56e5177938b409387583f29649ff233(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_f56e5177938b409387583f29649ff233(_e62ed9cb975690c448d3c0ba8eb14e73_f56e5177938b409387583f29649ff233 command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_38cdcd0693454eb0a911f2f35bda4453(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_38cdcd0693454eb0a911f2f35bda4453(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_38cdcd0693454eb0a911f2f35bda4453(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_38cdcd0693454eb0a911f2f35bda4453(_e62ed9cb975690c448d3c0ba8eb14e73_38cdcd0693454eb0a911f2f35bda4453 command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_79b464d6bf3c4c56ad97c27f9b0fb42c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_79b464d6bf3c4c56ad97c27f9b0fb42c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_79b464d6bf3c4c56ad97c27f9b0fb42c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_79b464d6bf3c4c56ad97c27f9b0fb42c(_e62ed9cb975690c448d3c0ba8eb14e73_79b464d6bf3c4c56ad97c27f9b0fb42c command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_220113f4c1424f5da9a300277e77eaa7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_220113f4c1424f5da9a300277e77eaa7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_220113f4c1424f5da9a300277e77eaa7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_220113f4c1424f5da9a300277e77eaa7(_e62ed9cb975690c448d3c0ba8eb14e73_220113f4c1424f5da9a300277e77eaa7 command)
		{
		}

		private void BakeCommandBinding__e62ed9cb975690c448d3c0ba8eb14e73_eb37f76457f64f48b819a77366201968(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e62ed9cb975690c448d3c0ba8eb14e73_eb37f76457f64f48b819a77366201968(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e62ed9cb975690c448d3c0ba8eb14e73_eb37f76457f64f48b819a77366201968(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e62ed9cb975690c448d3c0ba8eb14e73_eb37f76457f64f48b819a77366201968(_e62ed9cb975690c448d3c0ba8eb14e73_eb37f76457f64f48b819a77366201968 command)
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
