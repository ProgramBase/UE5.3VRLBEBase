using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.MeshReplacementCommandChangeTarget")]
	public partial class UMeshReplacementCommandChangeTarget : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryFramework.MeshReplacementCommandChangeTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/GeometryFramework.MeshReplacementCommandChangeTarget")]
	public interface IMeshReplacementCommandChangeTarget : IInterface
	{
	}
}