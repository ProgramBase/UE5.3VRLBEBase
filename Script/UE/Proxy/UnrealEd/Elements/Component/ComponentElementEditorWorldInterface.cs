using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ComponentElementEditorWorldInterface")]
	public partial class UComponentElementEditorWorldInterface : UComponentElementWorldInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ComponentElementEditorWorldInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}