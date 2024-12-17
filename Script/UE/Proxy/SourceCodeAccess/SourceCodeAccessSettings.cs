using Script.CoreUObject;
using Script.Library;

namespace Script.SourceCodeAccess
{
	[PathName("/Script/SourceCodeAccess.SourceCodeAccessSettings")]
	public partial class USourceCodeAccessSettings : UObject, IStaticClass
	{
		public FString PreferredAccessor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreferredAccessor, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreferredAccessor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SourceCodeAccess.SourceCodeAccessSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PreferredAccessor = 0;
	}
}