using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.SoundfieldEndpointSettingsBase")]
	public partial class USoundfieldEndpointSettingsBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.SoundfieldEndpointSettingsBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}