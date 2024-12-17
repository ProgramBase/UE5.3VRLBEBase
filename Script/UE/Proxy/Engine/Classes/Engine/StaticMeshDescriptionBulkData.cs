using Script.CoreUObject;
using Script.MeshDescription;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StaticMeshDescriptionBulkData")]
	public partial class UStaticMeshDescriptionBulkData : UMeshDescriptionBaseBulkData, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StaticMeshDescriptionBulkData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}