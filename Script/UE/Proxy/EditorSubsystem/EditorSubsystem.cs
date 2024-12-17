using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EditorSubsystem
{
	[PathName("/Script/EditorSubsystem.EditorSubsystem")]
	public partial class UEditorSubsystem : UDynamicSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorSubsystem.EditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}