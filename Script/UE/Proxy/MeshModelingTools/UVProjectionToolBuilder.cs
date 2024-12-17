using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.UVProjectionToolBuilder")]
	public partial class UUVProjectionToolBuilder : USingleTargetWithSelectionToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.UVProjectionToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}