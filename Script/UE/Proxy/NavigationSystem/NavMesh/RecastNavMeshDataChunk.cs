using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.RecastNavMeshDataChunk")]
	public partial class URecastNavMeshDataChunk : UNavigationDataChunk, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.RecastNavMeshDataChunk");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}