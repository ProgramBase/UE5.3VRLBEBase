using Script.CoreUObject;
using Script.Library;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.GLTFSkeletalMeshExporter")]
	public partial class UGLTFSkeletalMeshExporter : UGLTFExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GLTFExporter.GLTFSkeletalMeshExporter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}