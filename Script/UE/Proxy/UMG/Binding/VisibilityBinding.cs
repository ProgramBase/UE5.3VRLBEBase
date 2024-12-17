using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.VisibilityBinding")]
	public partial class UVisibilityBinding : UPropertyBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.VisibilityBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual ESlateVisibility GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(ESlateVisibility*)__ReturnBuffer;
			}
		}

		private static uint __GetValue = 0;
	}
}