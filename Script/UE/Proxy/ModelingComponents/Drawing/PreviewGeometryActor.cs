using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.PreviewGeometryActor")]
	public partial class APreviewGeometryActor : AInternalToolFrameworkActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.PreviewGeometryActor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}