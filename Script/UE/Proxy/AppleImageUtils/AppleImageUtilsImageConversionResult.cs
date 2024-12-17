using Script.CoreUObject;
using Script.Library;

namespace Script.AppleImageUtils
{
	[PathName("/Script/AppleImageUtils.AppleImageUtilsImageConversionResult")]
	public partial class FAppleImageUtilsImageConversionResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AppleImageUtils.AppleImageUtilsImageConversionResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAppleImageUtilsImageConversionResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAppleImageUtilsImageConversionResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAppleImageUtilsImageConversionResult A, FAppleImageUtilsImageConversionResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAppleImageUtilsImageConversionResult A, FAppleImageUtilsImageConversionResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAppleImageUtilsImageConversionResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Error
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Error, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Error, __InBuffer);
				}
			}
		}

		public TArray<byte> ImageData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImageData, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImageData, __InBuffer);
				}
			}
		}

		private static uint __Error = 0;

		private static uint __ImageData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}