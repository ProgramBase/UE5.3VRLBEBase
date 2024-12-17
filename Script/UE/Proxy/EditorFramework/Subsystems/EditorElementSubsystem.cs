using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.EditorFramework
{
	[PathName("/Script/EditorFramework.EditorElementSubsystem")]
	public partial class UEditorElementSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorFramework.EditorElementSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}