using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.EnvironmentQueryEditor
{
	[PathName("/Script/EnvironmentQueryEditor.AssetDefinition_EnvironmentQuery")]
	public partial class UAssetDefinition_EnvironmentQuery : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnvironmentQueryEditor.AssetDefinition_EnvironmentQuery");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}