using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.BoolBinding")]
	public partial class UBoolBinding : UPropertyBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.BoolBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __GetValue = 0;
	}
}