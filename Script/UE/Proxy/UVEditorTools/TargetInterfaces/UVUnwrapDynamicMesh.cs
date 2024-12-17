using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVUnwrapDynamicMesh")]
	public partial class UUVUnwrapDynamicMesh : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVUnwrapDynamicMesh");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/UVEditorTools.UVUnwrapDynamicMesh")]
	public interface IUVUnwrapDynamicMesh : IInterface
	{
	}
}