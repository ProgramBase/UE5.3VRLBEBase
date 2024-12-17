using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.MouseCursorBinding")]
	public partial class UMouseCursorBinding : UPropertyBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.MouseCursorBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual EMouseCursor GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(EMouseCursor*)__ReturnBuffer;
			}
		}

		private static uint __GetValue = 0;
	}
}