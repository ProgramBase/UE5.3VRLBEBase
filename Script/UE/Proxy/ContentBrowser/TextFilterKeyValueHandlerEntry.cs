using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.TextFilterKeyValueHandlerEntry")]
	public partial class FTextFilterKeyValueHandlerEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ContentBrowser.TextFilterKeyValueHandlerEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTextFilterKeyValueHandlerEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTextFilterKeyValueHandlerEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTextFilterKeyValueHandlerEntry A, FTextFilterKeyValueHandlerEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTextFilterKeyValueHandlerEntry A, FTextFilterKeyValueHandlerEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTextFilterKeyValueHandlerEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Key
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Key, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Key, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UTextFilterKeyValueHandler> HandlerClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HandlerClass, __ReturnBuffer);

					return *(TSoftClassPtr<UTextFilterKeyValueHandler>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HandlerClass, __InBuffer);
				}
			}
		}

		private static uint __Key = 0;

		private static uint __HandlerClass = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}