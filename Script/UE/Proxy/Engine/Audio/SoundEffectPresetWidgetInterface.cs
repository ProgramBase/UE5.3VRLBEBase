using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundEffectPresetWidgetInterface")]
	public partial class USoundEffectPresetWidgetInterface : UAudioPanelWidgetInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundEffectPresetWidgetInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.SoundEffectPresetWidgetInterface")]
	public interface ISoundEffectPresetWidgetInterface : IAudioPanelWidgetInterface
	{
		 void OnPropertyChanged(USoundEffectPreset Preset, FName PropertyName);

		 void OnConstructed(USoundEffectPreset Preset);

		 TSubclassOf<USoundEffectPreset> GetClass();
	}
}