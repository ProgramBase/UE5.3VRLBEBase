using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.SynthesisEditor
{
	[PathName("/Script/SynthesisEditor.MonoWaveTableSynthPresetFactory")]
	public partial class UMonoWaveTableSynthPresetFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SynthesisEditor.MonoWaveTableSynthPresetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}