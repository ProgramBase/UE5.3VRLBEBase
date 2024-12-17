using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.AsyncEditorDelay")]
	public partial class UAsyncEditorDelay : UEditorUtilityBlueprintAsyncActionBase, IStaticClass
	{
		public FAsyncDelayComplete Complete
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Complete, __ReturnBuffer);

					return *(FAsyncDelayComplete*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Complete, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.AsyncEditorDelay");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAsyncEditorDelay AsyncEditorDelay(float Seconds, int MinimumFrames = 30)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = Seconds;

				*(int*)(__InBuffer + 4) = MinimumFrames;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsyncEditorDelay, __InBuffer, __ReturnBuffer);

				return *(UAsyncEditorDelay*)__ReturnBuffer;
			}
		}

		private static uint __Complete = 0;

		private static uint __AsyncEditorDelay = 0;
	}
}