using Script.CoreUObject;
using Script.Library;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.GLTFLevelExporter")]
	public partial class UGLTFLevelExporter : UGLTFExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GLTFExporter.GLTFLevelExporter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}