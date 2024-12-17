using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.MeshVertexCommandChangeTarget")]
	public partial class UMeshVertexCommandChangeTarget : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryFramework.MeshVertexCommandChangeTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/GeometryFramework.MeshVertexCommandChangeTarget")]
	public interface IMeshVertexCommandChangeTarget : IInterface
	{
	}
}