using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackModuleItemOutputCollection")]
	public partial class UNiagaraStackModuleItemOutputCollection : UNiagaraStackEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackModuleItemOutputCollection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}