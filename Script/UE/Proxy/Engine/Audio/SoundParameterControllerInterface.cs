using Script.CoreUObject;
using Script.AudioExtensions;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundParameterControllerInterface")]
	public partial class USoundParameterControllerInterface : UAudioParameterControllerInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundParameterControllerInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.SoundParameterControllerInterface")]
	public interface ISoundParameterControllerInterface : IAudioParameterControllerInterface
	{
	}
}