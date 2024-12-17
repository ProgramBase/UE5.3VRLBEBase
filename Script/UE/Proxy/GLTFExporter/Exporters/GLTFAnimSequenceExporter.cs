using Script.CoreUObject;
using Script.Library;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.GLTFAnimSequenceExporter")]
	public partial class UGLTFAnimSequenceExporter : UGLTFExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GLTFExporter.GLTFAnimSequenceExporter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}