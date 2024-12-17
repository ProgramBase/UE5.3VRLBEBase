using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.ColorBinding")]
	public partial class UColorBinding : UPropertyBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.ColorBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FSlateColor GetSlateValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSlateValue, __ReturnBuffer);

				return *(FSlateColor*)__ReturnBuffer;
			}
		}

		public virtual FLinearColor GetLinearValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLinearValue, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		private static uint __GetSlateValue = 0;

		private static uint __GetLinearValue = 0;
	}
}