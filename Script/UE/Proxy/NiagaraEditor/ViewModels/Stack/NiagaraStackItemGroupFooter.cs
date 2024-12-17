using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackItemGroupFooter")]
	public partial class UNiagaraStackItemGroupFooter : UNiagaraStackEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackItemGroupFooter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}