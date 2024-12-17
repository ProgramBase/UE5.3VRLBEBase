using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.PreviewMeshActor")]
	public partial class APreviewMeshActor : AInternalToolFrameworkActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.PreviewMeshActor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}