using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.StaticMeshLODGenerationSettingsFactory")]
	public partial class UStaticMeshLODGenerationSettingsFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.StaticMeshLODGenerationSettingsFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}