using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.GeometryMode
{
	[PathName("/Script/GeometryMode.BrushEditingSubsystemImpl")]
	public partial class UBrushEditingSubsystemImpl : UBrushEditingSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryMode.BrushEditingSubsystemImpl");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}