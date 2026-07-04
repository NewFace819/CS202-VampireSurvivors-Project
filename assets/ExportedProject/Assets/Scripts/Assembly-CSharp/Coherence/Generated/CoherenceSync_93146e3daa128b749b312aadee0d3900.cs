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
using VampireSurvivors.Objects.Characters.Enemies;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_93146e3daa128b749b312aadee0d3900 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _93146e3daa128b749b312aadee0d3900_41e89fb51e6d4da39caff2eb2f83cdb7_CommandTarget;

		private Enemy_TP_Death _93146e3daa128b749b312aadee0d3900_8c749a9f81514522bf2f89007f79934d_CommandTarget;

		private Enemy_TP_Death _93146e3daa128b749b312aadee0d3900_a0a09c657e6e4d26b52bcc38d9602707_CommandTarget;

		private Enemy_TP_Death _93146e3daa128b749b312aadee0d3900_8a3d185c09c341b28c23127462eb884c_CommandTarget;

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

		private void BakeCommandBinding__93146e3daa128b749b312aadee0d3900_41e89fb51e6d4da39caff2eb2f83cdb7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93146e3daa128b749b312aadee0d3900_41e89fb51e6d4da39caff2eb2f83cdb7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93146e3daa128b749b312aadee0d3900_41e89fb51e6d4da39caff2eb2f83cdb7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93146e3daa128b749b312aadee0d3900_41e89fb51e6d4da39caff2eb2f83cdb7(_93146e3daa128b749b312aadee0d3900_41e89fb51e6d4da39caff2eb2f83cdb7 command)
		{
		}

		private void BakeCommandBinding__93146e3daa128b749b312aadee0d3900_8c749a9f81514522bf2f89007f79934d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93146e3daa128b749b312aadee0d3900_8c749a9f81514522bf2f89007f79934d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93146e3daa128b749b312aadee0d3900_8c749a9f81514522bf2f89007f79934d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93146e3daa128b749b312aadee0d3900_8c749a9f81514522bf2f89007f79934d(_93146e3daa128b749b312aadee0d3900_8c749a9f81514522bf2f89007f79934d command)
		{
		}

		private void BakeCommandBinding__93146e3daa128b749b312aadee0d3900_a0a09c657e6e4d26b52bcc38d9602707(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93146e3daa128b749b312aadee0d3900_a0a09c657e6e4d26b52bcc38d9602707(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93146e3daa128b749b312aadee0d3900_a0a09c657e6e4d26b52bcc38d9602707(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93146e3daa128b749b312aadee0d3900_a0a09c657e6e4d26b52bcc38d9602707(_93146e3daa128b749b312aadee0d3900_a0a09c657e6e4d26b52bcc38d9602707 command)
		{
		}

		private void BakeCommandBinding__93146e3daa128b749b312aadee0d3900_8a3d185c09c341b28c23127462eb884c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93146e3daa128b749b312aadee0d3900_8a3d185c09c341b28c23127462eb884c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93146e3daa128b749b312aadee0d3900_8a3d185c09c341b28c23127462eb884c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93146e3daa128b749b312aadee0d3900_8a3d185c09c341b28c23127462eb884c(_93146e3daa128b749b312aadee0d3900_8a3d185c09c341b28c23127462eb884c command)
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
