using Script.CoreUObject;
using Script.Library;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.GLTFLevelSequenceExporter")]
	public partial class UGLTFLevelSequenceExporter : UGLTFExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GLTFExporter.GLTFLevelSequenceExporter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}