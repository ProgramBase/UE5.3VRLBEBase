using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.AudioEndpointSettingsBase")]
	public partial class UAudioEndpointSettingsBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.AudioEndpointSettingsBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}