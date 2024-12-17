using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraParameterCollectionInstanceFactoryNew")]
	public partial class UNiagaraParameterCollectionInstanceFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraParameterCollectionInstanceFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}