using Script.CoreUObject;
using Script.Library;

namespace Script.AudioLinkCore
{
	[PathName("/Script/AudioLinkCore.AudioLinkSettingsAbstract")]
	public partial class UAudioLinkSettingsAbstract : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioLinkCore.AudioLinkSettingsAbstract");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}