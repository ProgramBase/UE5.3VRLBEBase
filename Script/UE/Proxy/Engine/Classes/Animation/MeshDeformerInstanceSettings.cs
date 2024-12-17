using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MeshDeformerInstanceSettings")]
	public partial class UMeshDeformerInstanceSettings : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MeshDeformerInstanceSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}