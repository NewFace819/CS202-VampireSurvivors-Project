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
	public class CoherenceSync_fd1192722e04ed446ba8052703d71b52 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_b4c1a1fea97e4e8e94ca0fb52c8639bb_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_25cbd7964cea48ba838806dd46579d09_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_52f9e69331244f558f9834efd0416cef_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_228211666e04441aafcd4ac03ad37f7e_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_f98d3a3953ed479fb42b6d6a5f1b907d_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_90b5435b14d14ba58b81783b4beda2a1_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_25d4ffa0a77443039fe1f6c8f0436e8d_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_5ce370b9fd3a480bb733dcd348b4987c_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_897c77a50adf4432a15c6758b76a9e87_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_4e2a75085b784bf69bc47ac8576c9faa_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_cb4536447ecb46af9bc8036cb6fae88d_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_a43fc66b474a469f9725b919bb4307f5_CommandTarget;

		private CharacterController _fd1192722e04ed446ba8052703d71b52_3da580925e41452ea78dad9fa9b93f87_CommandTarget;

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

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_b4c1a1fea97e4e8e94ca0fb52c8639bb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_b4c1a1fea97e4e8e94ca0fb52c8639bb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_b4c1a1fea97e4e8e94ca0fb52c8639bb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_b4c1a1fea97e4e8e94ca0fb52c8639bb(_fd1192722e04ed446ba8052703d71b52_b4c1a1fea97e4e8e94ca0fb52c8639bb command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_25cbd7964cea48ba838806dd46579d09(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_25cbd7964cea48ba838806dd46579d09(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_25cbd7964cea48ba838806dd46579d09(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_25cbd7964cea48ba838806dd46579d09(_fd1192722e04ed446ba8052703d71b52_25cbd7964cea48ba838806dd46579d09 command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_52f9e69331244f558f9834efd0416cef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_52f9e69331244f558f9834efd0416cef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_52f9e69331244f558f9834efd0416cef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_52f9e69331244f558f9834efd0416cef(_fd1192722e04ed446ba8052703d71b52_52f9e69331244f558f9834efd0416cef command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_228211666e04441aafcd4ac03ad37f7e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_228211666e04441aafcd4ac03ad37f7e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_228211666e04441aafcd4ac03ad37f7e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_228211666e04441aafcd4ac03ad37f7e(_fd1192722e04ed446ba8052703d71b52_228211666e04441aafcd4ac03ad37f7e command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_f98d3a3953ed479fb42b6d6a5f1b907d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_f98d3a3953ed479fb42b6d6a5f1b907d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_f98d3a3953ed479fb42b6d6a5f1b907d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_f98d3a3953ed479fb42b6d6a5f1b907d(_fd1192722e04ed446ba8052703d71b52_f98d3a3953ed479fb42b6d6a5f1b907d command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_90b5435b14d14ba58b81783b4beda2a1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_90b5435b14d14ba58b81783b4beda2a1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_90b5435b14d14ba58b81783b4beda2a1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_90b5435b14d14ba58b81783b4beda2a1(_fd1192722e04ed446ba8052703d71b52_90b5435b14d14ba58b81783b4beda2a1 command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_25d4ffa0a77443039fe1f6c8f0436e8d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_25d4ffa0a77443039fe1f6c8f0436e8d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_25d4ffa0a77443039fe1f6c8f0436e8d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_25d4ffa0a77443039fe1f6c8f0436e8d(_fd1192722e04ed446ba8052703d71b52_25d4ffa0a77443039fe1f6c8f0436e8d command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_5ce370b9fd3a480bb733dcd348b4987c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_5ce370b9fd3a480bb733dcd348b4987c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_5ce370b9fd3a480bb733dcd348b4987c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_5ce370b9fd3a480bb733dcd348b4987c(_fd1192722e04ed446ba8052703d71b52_5ce370b9fd3a480bb733dcd348b4987c command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_897c77a50adf4432a15c6758b76a9e87(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_897c77a50adf4432a15c6758b76a9e87(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_897c77a50adf4432a15c6758b76a9e87(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_897c77a50adf4432a15c6758b76a9e87(_fd1192722e04ed446ba8052703d71b52_897c77a50adf4432a15c6758b76a9e87 command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_4e2a75085b784bf69bc47ac8576c9faa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_4e2a75085b784bf69bc47ac8576c9faa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_4e2a75085b784bf69bc47ac8576c9faa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_4e2a75085b784bf69bc47ac8576c9faa(_fd1192722e04ed446ba8052703d71b52_4e2a75085b784bf69bc47ac8576c9faa command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_cb4536447ecb46af9bc8036cb6fae88d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_cb4536447ecb46af9bc8036cb6fae88d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_cb4536447ecb46af9bc8036cb6fae88d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_cb4536447ecb46af9bc8036cb6fae88d(_fd1192722e04ed446ba8052703d71b52_cb4536447ecb46af9bc8036cb6fae88d command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_a43fc66b474a469f9725b919bb4307f5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_a43fc66b474a469f9725b919bb4307f5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_a43fc66b474a469f9725b919bb4307f5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_a43fc66b474a469f9725b919bb4307f5(_fd1192722e04ed446ba8052703d71b52_a43fc66b474a469f9725b919bb4307f5 command)
		{
		}

		private void BakeCommandBinding__fd1192722e04ed446ba8052703d71b52_3da580925e41452ea78dad9fa9b93f87(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fd1192722e04ed446ba8052703d71b52_3da580925e41452ea78dad9fa9b93f87(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fd1192722e04ed446ba8052703d71b52_3da580925e41452ea78dad9fa9b93f87(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fd1192722e04ed446ba8052703d71b52_3da580925e41452ea78dad9fa9b93f87(_fd1192722e04ed446ba8052703d71b52_3da580925e41452ea78dad9fa9b93f87 command)
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
