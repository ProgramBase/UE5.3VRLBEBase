using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraScratchPadViewModel")]
	public partial class UNiagaraScratchPadViewModel : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraScratchPadViewModel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}