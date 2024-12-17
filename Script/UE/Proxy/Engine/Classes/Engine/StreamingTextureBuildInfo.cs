using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StreamingTextureBuildInfo")]
	public partial class FStreamingTextureBuildInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StreamingTextureBuildInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStreamingTextureBuildInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStreamingTextureBuildInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStreamingTextureBuildInfo A, FStreamingTextureBuildInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStreamingTextureBuildInfo A, FStreamingTextureBuildInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStreamingTextureBuildInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint PackedRelativeBox
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PackedRelativeBox, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PackedRelativeBox, __InBuffer);
				}
			}
		}

		public int TextureLevelIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextureLevelIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextureLevelIndex, __InBuffer);
				}
			}
		}

		public float TexelFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TexelFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TexelFactor, __InBuffer);
				}
			}
		}

		private static uint __PackedRelativeBox = 0;

		private static uint __TextureLevelIndex = 0;

		private static uint __TexelFactor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}