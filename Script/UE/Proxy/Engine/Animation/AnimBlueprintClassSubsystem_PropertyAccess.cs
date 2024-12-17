using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimBlueprintClassSubsystem_PropertyAccess")]
	public partial class UAnimBlueprintClassSubsystem_PropertyAccess : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimBlueprintClassSubsystem_PropertyAccess");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}