﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimeVirtualTextureParameterValue")]
	public partial class FRuntimeVirtualTextureParameterValue : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RuntimeVirtualTextureParameterValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRuntimeVirtualTextureParameterValue() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRuntimeVirtualTextureParameterValue() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRuntimeVirtualTextureParameterValue A, FRuntimeVirtualTextureParameterValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRuntimeVirtualTextureParameterValue A, FRuntimeVirtualTextureParameterValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRuntimeVirtualTextureParameterValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMaterialParameterInfo ParameterInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterInfo, __ReturnBuffer);

					return *(FMaterialParameterInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterInfo, __InBuffer);
				}
			}
		}

		public URuntimeVirtualTexture ParameterValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __ReturnBuffer);

					return *(URuntimeVirtualTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __InBuffer);
				}
			}
		}

		public FGuid ExpressionGUID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionGUID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionGUID, __InBuffer);
				}
			}
		}

		private static uint __ParameterInfo = 0;

		private static uint __ParameterValue = 0;

		private static uint __ExpressionGUID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}