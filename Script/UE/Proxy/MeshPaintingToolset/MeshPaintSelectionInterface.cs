using Script.CoreUObject;
using Script.Library;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.MeshPaintSelectionInterface")]
	public partial class UMeshPaintSelectionInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintingToolset.MeshPaintSelectionInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MeshPaintingToolset.MeshPaintSelectionInterface")]
	public interface IMeshPaintSelectionInterface : IInterface
	{
	}
}