using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackModuleItemOutput")]
	public partial class UNiagaraStackModuleItemOutput : UNiagaraStackEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackModuleItemOutput");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}