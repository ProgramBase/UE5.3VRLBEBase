using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotifyMirrorInspectionLibrary")]
	public partial class UAnimNotifyMirrorInspectionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimNotifyMirrorInspectionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EventReference">
		/// The event to inspect
		/// </param>
		public static bool IsTriggeredByMirroredAnimation(FAnimNotifyEventReference EventReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsTriggeredByMirroredAnimation, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EventReference">
		/// The event to inspect
		/// </param>
		public static UMirrorDataTable GetMirrorDataTable(FAnimNotifyEventReference EventReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMirrorDataTable, __InBuffer, __ReturnBuffer);

				return *(UMirrorDataTable*)__ReturnBuffer;
			}
		}

		private static uint __IsTriggeredByMirroredAnimation = 0;

		private static uint __GetMirrorDataTable = 0;
	}
}