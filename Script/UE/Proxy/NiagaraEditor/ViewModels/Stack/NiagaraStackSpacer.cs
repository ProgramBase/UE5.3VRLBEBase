using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackSpacer")]
	public partial class UNiagaraStackSpacer : UNiagaraStackEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackSpacer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}