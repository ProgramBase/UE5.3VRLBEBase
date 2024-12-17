using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.CheckedStateBinding")]
	public partial class UCheckedStateBinding : UPropertyBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.CheckedStateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual ECheckBoxState GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(ECheckBoxState*)__ReturnBuffer;
			}
		}

		private static uint __GetValue = 0;
	}
}