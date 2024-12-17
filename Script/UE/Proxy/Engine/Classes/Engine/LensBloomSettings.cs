using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LensBloomSettings")]
	public partial class FLensBloomSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.LensBloomSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLensBloomSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLensBloomSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLensBloomSettings A, FLensBloomSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLensBloomSettings A, FLensBloomSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLensBloomSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGaussianSumBloomSettings GaussianSum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GaussianSum, __ReturnBuffer);

					return *(FGaussianSumBloomSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GaussianSum, __InBuffer);
				}
			}
		}

		public FConvolutionBloomSettings Convolution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Convolution, __ReturnBuffer);

					return *(FConvolutionBloomSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Convolution, __InBuffer);
				}
			}
		}

		public EBloomMethod Method
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Method, __ReturnBuffer);

					return *(EBloomMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Method, __InBuffer);
				}
			}
		}

		private static uint __GaussianSum = 0;

		private static uint __Convolution = 0;

		private static uint __Method = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}