using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.AudioBusSubsystem")]
	public partial class UAudioBusSubsystem : UAudioEngineSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioMixer.AudioBusSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}