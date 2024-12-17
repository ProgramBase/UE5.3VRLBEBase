using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TextureSourceColorSettings")]
	public partial class FTextureSourceColorSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TextureSourceColorSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTextureSourceColorSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTextureSourceColorSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTextureSourceColorSettings A, FTextureSourceColorSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTextureSourceColorSettings A, FTextureSourceColorSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTextureSourceColorSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ETextureSourceEncoding EncodingOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EncodingOverride, __ReturnBuffer);

					return *(ETextureSourceEncoding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EncodingOverride, __InBuffer);
				}
			}
		}

		public ETextureColorSpace ColorSpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ColorSpace, __ReturnBuffer);

					return *(ETextureColorSpace*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ColorSpace, __InBuffer);
				}
			}
		}

		public FVector2D RedChromaticityCoordinate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RedChromaticityCoordinate, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RedChromaticityCoordinate, __InBuffer);
				}
			}
		}

		public FVector2D GreenChromaticityCoordinate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GreenChromaticityCoordinate, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GreenChromaticityCoordinate, __InBuffer);
				}
			}
		}

		public FVector2D BlueChromaticityCoordinate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlueChromaticityCoordinate, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlueChromaticityCoordinate, __InBuffer);
				}
			}
		}

		public FVector2D WhiteChromaticityCoordinate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WhiteChromaticityCoordinate, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WhiteChromaticityCoordinate, __InBuffer);
				}
			}
		}

		public ETextureChromaticAdaptationMethod ChromaticAdaptationMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChromaticAdaptationMethod, __ReturnBuffer);

					return *(ETextureChromaticAdaptationMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChromaticAdaptationMethod, __InBuffer);
				}
			}
		}

		private static uint __EncodingOverride = 0;

		private static uint __ColorSpace = 0;

		private static uint __RedChromaticityCoordinate = 0;

		private static uint __GreenChromaticityCoordinate = 0;

		private static uint __BlueChromaticityCoordinate = 0;

		private static uint __WhiteChromaticityCoordinate = 0;

		private static uint __ChromaticAdaptationMethod = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}