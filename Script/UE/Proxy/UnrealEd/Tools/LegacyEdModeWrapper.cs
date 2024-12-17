using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LegacyEdModeWrapper")]
	public partial class ULegacyEdModeWrapper : UEdMode, IStaticClass, ILegacyEdModeWidgetInterface, ILegacyEdModeToolInterface, ILegacyEdModeSelectInterface, ILegacyEdModeDrawHelperInterface, ILegacyEdModeViewportInterface
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LegacyEdModeWrapper");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __ExecuteUbergraph = 0;
	}
}