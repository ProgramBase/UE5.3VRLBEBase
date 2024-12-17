using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaSource")]
	public partial class UMediaSource : UObject, IStaticClass
	{
		public UTexture ThumbnailImage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailImage, __ReturnBuffer);

					return *(UTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailImage, __InBuffer);
				}
			}
		}

		public UObject MediaSourceRenderer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediaSourceRenderer, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediaSourceRenderer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaAssets.MediaSource");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// true if validation passed, false otherwise.
		/// </returns>
		public virtual bool Validate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Validate, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetMediaOptionString(FName Key, FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMediaOptionString, __InBuffer);
			}
		}

		public virtual void SetMediaOptionInt64(FName Key, long Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(long*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMediaOptionInt64, __InBuffer);
			}
		}

		public virtual void SetMediaOptionFloat(FName Key, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMediaOptionFloat, __InBuffer);
			}
		}

		public virtual void SetMediaOptionBool(FName Key, bool Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMediaOptionBool, __InBuffer);
			}
		}

		/// <see>
		/// GetProxies
		/// </see>
		/// <returns>
		/// The media URL.
		/// </returns>
		public virtual FString GetUrl()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetUrl, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __ThumbnailImage = 0;

		private static uint __MediaSourceRenderer = 0;

		private static uint __Validate = 0;

		private static uint __SetMediaOptionString = 0;

		private static uint __SetMediaOptionInt64 = 0;

		private static uint __SetMediaOptionFloat = 0;

		private static uint __SetMediaOptionBool = 0;

		private static uint __GetUrl = 0;
	}
}