using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AudioMixerCommandlet")]
	public partial class UAudioMixerCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AudioMixerCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}