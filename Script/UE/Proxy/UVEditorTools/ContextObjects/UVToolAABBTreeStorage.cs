using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVToolAABBTreeStorage")]
	public partial class UUVToolAABBTreeStorage : UUVToolContextObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVToolAABBTreeStorage");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}