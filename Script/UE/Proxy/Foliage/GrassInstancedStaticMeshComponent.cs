using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.GrassInstancedStaticMeshComponent")]
	public partial class UGrassInstancedStaticMeshComponent : UHierarchicalInstancedStaticMeshComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Foliage.GrassInstancedStaticMeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}