using Script.CoreUObject;
using Script.Library;

namespace Script.ImageWriteQueue
{
	[PathName("/Script/ImageWriteQueue.ImageWriteOptions")]
	public partial class FImageWriteOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ImageWriteQueue.ImageWriteOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FImageWriteOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FImageWriteOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FImageWriteOptions A, FImageWriteOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FImageWriteOptions A, FImageWriteOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FImageWriteOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EDesiredImageFormat Format
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Format, __ReturnBuffer);

					return *(EDesiredImageFormat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Format, __InBuffer);
				}
			}
		}

		public FOnImageWriteComplete OnComplete
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OnComplete, __ReturnBuffer);

					return *(FOnImageWriteComplete*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OnComplete, __InBuffer);
				}
			}
		}

		public int CompressionQuality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompressionQuality, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompressionQuality, __InBuffer);
				}
			}
		}

		public bool bOverwriteFile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverwriteFile, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverwriteFile, __InBuffer);
				}
			}
		}

		public bool bAsync
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAsync, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAsync, __InBuffer);
				}
			}
		}

		private static uint __Format = 0;

		private static uint __OnComplete = 0;

		private static uint __CompressionQuality = 0;

		private static uint __bOverwriteFile = 0;

		private static uint __bAsync = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}