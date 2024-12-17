using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PropertyEditorRowGeneratorTest")]
	public partial class UPropertyEditorRowGeneratorTest : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PropertyEditorRowGeneratorTest");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}