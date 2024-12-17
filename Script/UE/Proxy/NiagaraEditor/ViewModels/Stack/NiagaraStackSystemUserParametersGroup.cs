using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackSystemUserParametersGroup")]
	public partial class UNiagaraStackSystemUserParametersGroup : UNiagaraStackItemGroup, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackSystemUserParametersGroup");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}