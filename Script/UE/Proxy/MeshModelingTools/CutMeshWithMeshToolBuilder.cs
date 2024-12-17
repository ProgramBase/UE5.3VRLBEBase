using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.CutMeshWithMeshToolBuilder")]
	public partial class UCutMeshWithMeshToolBuilder : UBaseCreateFromSelectedToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.CutMeshWithMeshToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}