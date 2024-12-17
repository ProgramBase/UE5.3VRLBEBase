﻿using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeProxyMaterialOverride")]
	public partial class FLandscapeProxyMaterialOverride : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.LandscapeProxyMaterialOverride");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeProxyMaterialOverride() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapeProxyMaterialOverride() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapeProxyMaterialOverride A, FLandscapeProxyMaterialOverride B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeProxyMaterialOverride A, FLandscapeProxyMaterialOverride B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeProxyMaterialOverride;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPerPlatformInt LODIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LODIndex, __ReturnBuffer);

					return *(FPerPlatformInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LODIndex, __InBuffer);
				}
			}
		}

		public UMaterialInterface Material
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Material, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Material, __InBuffer);
				}
			}
		}

		private static uint __LODIndex = 0;

		private static uint __Material = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}