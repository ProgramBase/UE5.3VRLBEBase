using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.AssetDefinition_NiagaraParameterCollectionInstance")]
	public partial class UAssetDefinition_NiagaraParameterCollectionInstance : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.AssetDefinition_NiagaraParameterCollectionInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}