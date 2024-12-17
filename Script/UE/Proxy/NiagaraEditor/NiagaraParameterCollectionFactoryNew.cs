using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraParameterCollectionFactoryNew")]
	public partial class UNiagaraParameterCollectionFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraParameterCollectionFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}