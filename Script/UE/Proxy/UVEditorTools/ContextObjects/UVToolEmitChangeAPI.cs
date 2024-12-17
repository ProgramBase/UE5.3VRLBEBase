using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVToolEmitChangeAPI")]
	public partial class UUVToolEmitChangeAPI : UUVToolContextObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVToolEmitChangeAPI");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}