using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ResonanceAudioEditor
{
	[PathName("/Script/ResonanceAudioEditor.ResonanceAudioSpatializationSourceSettingsFactory")]
	public partial class UResonanceAudioSpatializationSourceSettingsFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ResonanceAudioEditor.ResonanceAudioSpatializationSourceSettingsFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}