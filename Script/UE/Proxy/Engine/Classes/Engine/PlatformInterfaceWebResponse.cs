using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlatformInterfaceWebResponse")]
	public partial class UPlatformInterfaceWebResponse : UObject, IStaticClass
	{
		public FString OriginalURL
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalURL, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalURL, __InBuffer);
				}
			}
		}

		public int ResponseCode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ResponseCode, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ResponseCode, __InBuffer);
				}
			}
		}

		public int Tag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Tag, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Tag, __InBuffer);
				}
			}
		}

		public FString StringResponse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StringResponse, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StringResponse, __InBuffer);
				}
			}
		}

		public TArray<byte> BinaryResponse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BinaryResponse, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BinaryResponse, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlatformInterfaceWebResponse");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// the number of header/value pairs */
		/// </returns>
		public virtual int GetNumHeaders()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumHeaders, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the value for the given header (or "" if no matching header) */
		/// </returns>
		public virtual FString GetHeaderValue(FString HeaderName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = HeaderName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetHeaderValue, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual void GetHeader(int HeaderIndex, ref FString Header, ref FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(int*)(__InBuffer) = HeaderIndex;

				*(nint*)(__InBuffer + 4) = Header?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetHeader, __InBuffer, __OutBuffer);

				Header = *(FString*)(__OutBuffer);

				Value = *(FString*)(__OutBuffer + 8);

			}
		}

		private static uint __OriginalURL = 0;

		private static uint __ResponseCode = 0;

		private static uint __Tag = 0;

		private static uint __StringResponse = 0;

		private static uint __BinaryResponse = 0;

		private static uint __GetNumHeaders = 0;

		private static uint __GetHeaderValue = 0;

		private static uint __GetHeader = 0;
	}
}