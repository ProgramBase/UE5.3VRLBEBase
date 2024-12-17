using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraEditorParametersAdapterBase")]
	public partial class UNiagaraEditorParametersAdapterBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraEditorParametersAdapterBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}