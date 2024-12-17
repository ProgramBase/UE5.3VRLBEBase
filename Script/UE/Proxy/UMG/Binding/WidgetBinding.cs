using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetBinding")]
	public partial class UWidgetBinding : UPropertyBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UWidget GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(UWidget*)__ReturnBuffer;
			}
		}

		private static uint __GetValue = 0;
	}
}