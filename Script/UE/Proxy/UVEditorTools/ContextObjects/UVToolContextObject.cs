using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVToolContextObject")]
	public partial class UUVToolContextObject : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVToolContextObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}