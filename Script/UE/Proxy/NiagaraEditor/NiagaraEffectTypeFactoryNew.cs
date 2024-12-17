using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraEffectTypeFactoryNew")]
	public partial class UNiagaraEffectTypeFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraEffectTypeFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}