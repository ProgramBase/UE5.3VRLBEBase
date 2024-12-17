using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.HoleFillToolBuilder")]
	public partial class UHoleFillToolBuilder : USingleSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.HoleFillToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}