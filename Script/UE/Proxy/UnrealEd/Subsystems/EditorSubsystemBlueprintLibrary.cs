using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.EditorSubsystem;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorSubsystemBlueprintLibrary")]
	public partial class UEditorSubsystemBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorSubsystemBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UEditorSubsystem GetEditorSubsystem(TSubclassOf<UEditorSubsystem> Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEditorSubsystem, __InBuffer, __ReturnBuffer);

				return *(UEditorSubsystem*)__ReturnBuffer;
			}
		}

		private static uint __GetEditorSubsystem = 0;
	}
}