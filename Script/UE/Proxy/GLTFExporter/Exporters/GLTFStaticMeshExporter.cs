using Script.CoreUObject;
using Script.Library;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.GLTFStaticMeshExporter")]
	public partial class UGLTFStaticMeshExporter : UGLTFExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GLTFExporter.GLTFStaticMeshExporter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}