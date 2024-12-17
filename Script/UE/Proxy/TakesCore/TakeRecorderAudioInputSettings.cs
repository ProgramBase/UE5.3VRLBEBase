using Script.CoreUObject;
using Script.Library;

namespace Script.TakesCore
{
	[PathName("/Script/TakesCore.TakeRecorderAudioInputSettings")]
	public partial class UTakeRecorderAudioInputSettings : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakesCore.TakeRecorderAudioInputSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}