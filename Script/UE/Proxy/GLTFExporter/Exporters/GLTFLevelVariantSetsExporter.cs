using Script.CoreUObject;
using Script.Library;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.GLTFLevelVariantSetsExporter")]
	public partial class UGLTFLevelVariantSetsExporter : UGLTFExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GLTFExporter.GLTFLevelVariantSetsExporter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}