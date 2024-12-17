using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.SoundfieldEncodingSettingsBase")]
	public partial class USoundfieldEncodingSettingsBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.SoundfieldEncodingSettingsBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}