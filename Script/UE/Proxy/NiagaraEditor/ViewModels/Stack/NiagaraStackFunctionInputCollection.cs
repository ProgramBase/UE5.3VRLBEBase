using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackFunctionInputCollection")]
	public partial class UNiagaraStackFunctionInputCollection : UNiagaraStackValueCollection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackFunctionInputCollection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}