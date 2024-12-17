using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.AssetDefinition_NiagaraParameterCollection")]
	public partial class UAssetDefinition_NiagaraParameterCollection : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.AssetDefinition_NiagaraParameterCollection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}