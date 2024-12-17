using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackModuleItemLinkedInputCollection")]
	public partial class UNiagaraStackModuleItemLinkedInputCollection : UNiagaraStackEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackModuleItemLinkedInputCollection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}