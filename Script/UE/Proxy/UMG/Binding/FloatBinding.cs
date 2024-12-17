using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.FloatBinding")]
	public partial class UFloatBinding : UPropertyBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.FloatBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual float GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __GetValue = 0;
	}
}