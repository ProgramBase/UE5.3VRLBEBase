using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.MeshCommandChangeTarget")]
	public partial class UMeshCommandChangeTarget : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryFramework.MeshCommandChangeTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/GeometryFramework.MeshCommandChangeTarget")]
	public interface IMeshCommandChangeTarget : IInterface
	{
	}
}