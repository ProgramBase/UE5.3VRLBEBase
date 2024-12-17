using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.SynthesisEditor
{
	[PathName("/Script/SynthesisEditor.ModularSynthPresetBankFactory")]
	public partial class UModularSynthPresetBankFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SynthesisEditor.ModularSynthPresetBankFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}