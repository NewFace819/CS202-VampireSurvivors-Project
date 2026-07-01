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
	public class CoherenceSync_73b814dc845c89941be1a604a3c13b05 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_573e6885b9414273aa9ddfaf109fccda_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_27746a3ce3384726a9374479826278ae_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_29dbc49aa278491f93568d2a9cbd6101_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_f20f2a49061a4b92a59a07f4b98de36b_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_e8e89065bcaf4731972322bb27f1c849_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_36004cefb10940f88069b60cf2b88713_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_2b2c4a9629ff44ecac50550a7fe1e107_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_1e8e934757f645758e2cec8f90537ba0_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_05d5a6752005435e939e93324fd1593f_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_fc2dee5220854ad8acdb411aaf083638_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_e98724fa2d824b40aad87b74bdc4b6f0_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_853b7a1445e544338d38d53248ba872b_CommandTarget;

		private CharacterController _73b814dc845c89941be1a604a3c13b05_534b3de8a8b74574945d3a74e4f7413f_CommandTarget;

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

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_573e6885b9414273aa9ddfaf109fccda(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_573e6885b9414273aa9ddfaf109fccda(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_573e6885b9414273aa9ddfaf109fccda(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_573e6885b9414273aa9ddfaf109fccda(_73b814dc845c89941be1a604a3c13b05_573e6885b9414273aa9ddfaf109fccda command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_27746a3ce3384726a9374479826278ae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_27746a3ce3384726a9374479826278ae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_27746a3ce3384726a9374479826278ae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_27746a3ce3384726a9374479826278ae(_73b814dc845c89941be1a604a3c13b05_27746a3ce3384726a9374479826278ae command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_29dbc49aa278491f93568d2a9cbd6101(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_29dbc49aa278491f93568d2a9cbd6101(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_29dbc49aa278491f93568d2a9cbd6101(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_29dbc49aa278491f93568d2a9cbd6101(_73b814dc845c89941be1a604a3c13b05_29dbc49aa278491f93568d2a9cbd6101 command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_f20f2a49061a4b92a59a07f4b98de36b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_f20f2a49061a4b92a59a07f4b98de36b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_f20f2a49061a4b92a59a07f4b98de36b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_f20f2a49061a4b92a59a07f4b98de36b(_73b814dc845c89941be1a604a3c13b05_f20f2a49061a4b92a59a07f4b98de36b command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_e8e89065bcaf4731972322bb27f1c849(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_e8e89065bcaf4731972322bb27f1c849(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_e8e89065bcaf4731972322bb27f1c849(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_e8e89065bcaf4731972322bb27f1c849(_73b814dc845c89941be1a604a3c13b05_e8e89065bcaf4731972322bb27f1c849 command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_36004cefb10940f88069b60cf2b88713(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_36004cefb10940f88069b60cf2b88713(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_36004cefb10940f88069b60cf2b88713(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_36004cefb10940f88069b60cf2b88713(_73b814dc845c89941be1a604a3c13b05_36004cefb10940f88069b60cf2b88713 command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_2b2c4a9629ff44ecac50550a7fe1e107(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_2b2c4a9629ff44ecac50550a7fe1e107(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_2b2c4a9629ff44ecac50550a7fe1e107(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_2b2c4a9629ff44ecac50550a7fe1e107(_73b814dc845c89941be1a604a3c13b05_2b2c4a9629ff44ecac50550a7fe1e107 command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_1e8e934757f645758e2cec8f90537ba0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_1e8e934757f645758e2cec8f90537ba0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_1e8e934757f645758e2cec8f90537ba0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_1e8e934757f645758e2cec8f90537ba0(_73b814dc845c89941be1a604a3c13b05_1e8e934757f645758e2cec8f90537ba0 command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_05d5a6752005435e939e93324fd1593f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_05d5a6752005435e939e93324fd1593f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_05d5a6752005435e939e93324fd1593f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_05d5a6752005435e939e93324fd1593f(_73b814dc845c89941be1a604a3c13b05_05d5a6752005435e939e93324fd1593f command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_fc2dee5220854ad8acdb411aaf083638(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_fc2dee5220854ad8acdb411aaf083638(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_fc2dee5220854ad8acdb411aaf083638(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_fc2dee5220854ad8acdb411aaf083638(_73b814dc845c89941be1a604a3c13b05_fc2dee5220854ad8acdb411aaf083638 command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_e98724fa2d824b40aad87b74bdc4b6f0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_e98724fa2d824b40aad87b74bdc4b6f0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_e98724fa2d824b40aad87b74bdc4b6f0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_e98724fa2d824b40aad87b74bdc4b6f0(_73b814dc845c89941be1a604a3c13b05_e98724fa2d824b40aad87b74bdc4b6f0 command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_853b7a1445e544338d38d53248ba872b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_853b7a1445e544338d38d53248ba872b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_853b7a1445e544338d38d53248ba872b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_853b7a1445e544338d38d53248ba872b(_73b814dc845c89941be1a604a3c13b05_853b7a1445e544338d38d53248ba872b command)
		{
		}

		private void BakeCommandBinding__73b814dc845c89941be1a604a3c13b05_534b3de8a8b74574945d3a74e4f7413f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73b814dc845c89941be1a604a3c13b05_534b3de8a8b74574945d3a74e4f7413f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73b814dc845c89941be1a604a3c13b05_534b3de8a8b74574945d3a74e4f7413f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73b814dc845c89941be1a604a3c13b05_534b3de8a8b74574945d3a74e4f7413f(_73b814dc845c89941be1a604a3c13b05_534b3de8a8b74574945d3a74e4f7413f command)
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
