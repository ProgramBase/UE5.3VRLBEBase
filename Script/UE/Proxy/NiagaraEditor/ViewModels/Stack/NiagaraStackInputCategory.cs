using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackInputCategory")]
	public partial class UNiagaraStackInputCategory : UNiagaraStackCategory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackInputCategory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}