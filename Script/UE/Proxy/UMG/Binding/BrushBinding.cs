using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.BrushBinding")]
	public partial class UBrushBinding : UPropertyBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.BrushBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FSlateBrush GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(FSlateBrush*)__ReturnBuffer;
			}
		}

		private static uint __GetValue = 0;
	}
}