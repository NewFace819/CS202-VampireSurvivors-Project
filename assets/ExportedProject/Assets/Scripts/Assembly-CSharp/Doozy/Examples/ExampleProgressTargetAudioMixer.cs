using Doozy.Engine.Progress;
using UnityEngine.Audio;

namespace Doozy.Examples
{
	public class ExampleProgressTargetAudioMixer : ProgressTarget
	{
		public AudioMixer AudioMixer;

		public string ExposedParameter;

		public TargetVariable TargetVariable;

		private float m_targetValue;

		public override void UpdateTarget(Progressor progressor)
		{
		}
	}
}
