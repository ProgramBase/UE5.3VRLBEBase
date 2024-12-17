using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackRenderItemGroup")]
	public partial class UNiagaraStackRenderItemGroup : UNiagaraStackItemGroup, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackRenderItemGroup");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}