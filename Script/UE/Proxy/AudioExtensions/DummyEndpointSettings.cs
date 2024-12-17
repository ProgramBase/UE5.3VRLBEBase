using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.DummyEndpointSettings")]
	public partial class UDummyEndpointSettings : UAudioEndpointSettingsBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.DummyEndpointSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}