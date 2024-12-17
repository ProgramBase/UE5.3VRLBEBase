using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackItemFooter")]
	public partial class UNiagaraStackItemFooter : UNiagaraStackEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackItemFooter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}