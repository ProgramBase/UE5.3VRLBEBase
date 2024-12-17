using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SMInstanceElementEditorWorldInterface")]
	public partial class USMInstanceElementEditorWorldInterface : USMInstanceElementWorldInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SMInstanceElementEditorWorldInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}