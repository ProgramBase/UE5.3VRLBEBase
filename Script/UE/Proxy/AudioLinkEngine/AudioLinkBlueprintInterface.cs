using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AudioLinkEngine
{
	[PathName("/Script/AudioLinkEngine.AudioLinkBlueprintInterface")]
	public partial class UAudioLinkBlueprintInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioLinkEngine.AudioLinkBlueprintInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AudioLinkEngine.AudioLinkBlueprintInterface")]
	public interface IAudioLinkBlueprintInterface : IInterface
	{
		 void StopLink();

		 void SetLinkSound(USoundBase NewSound);

		 void PlayLink(float StartTime = 0.000000f);

		 bool IsLinkPlaying();
	}
}