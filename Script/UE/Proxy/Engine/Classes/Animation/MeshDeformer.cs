using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MeshDeformer")]
	public partial class UMeshDeformer : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MeshDeformer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}