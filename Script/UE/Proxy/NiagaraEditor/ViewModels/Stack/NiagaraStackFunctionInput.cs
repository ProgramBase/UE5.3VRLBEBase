using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackFunctionInput")]
	public partial class UNiagaraStackFunctionInput : UNiagaraStackItemContent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackFunctionInput");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}