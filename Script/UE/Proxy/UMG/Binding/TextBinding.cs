using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.TextBinding")]
	public partial class UTextBinding : UPropertyBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.TextBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FText GetTextValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTextValue, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual FString GetStringValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetStringValue, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __GetTextValue = 0;

		private static uint __GetStringValue = 0;
	}
}