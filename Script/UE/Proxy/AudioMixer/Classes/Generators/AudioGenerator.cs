using Script.CoreUObject;
using Script.Library;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.AudioGenerator")]
	public partial class UAudioGenerator : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioMixer.AudioGenerator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}