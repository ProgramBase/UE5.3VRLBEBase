using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVSeamSewAction")]
	public partial class UUVSeamSewAction : UUVToolAction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVSeamSewAction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}