using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraEditorDataBase")]
	public partial class UNiagaraEditorDataBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraEditorDataBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}