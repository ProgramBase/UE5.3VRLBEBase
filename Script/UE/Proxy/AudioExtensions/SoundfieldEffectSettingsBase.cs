using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.SoundfieldEffectSettingsBase")]
	public partial class USoundfieldEffectSettingsBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.SoundfieldEffectSettingsBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}