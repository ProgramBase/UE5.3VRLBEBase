﻿using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.CreateMaterialObjectResult")]
	public partial class FCreateMaterialObjectResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ModelingComponents.CreateMaterialObjectResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCreateMaterialObjectResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCreateMaterialObjectResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCreateMaterialObjectResult A, FCreateMaterialObjectResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCreateMaterialObjectResult A, FCreateMaterialObjectResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCreateMaterialObjectResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ECreateModelingObjectResult ResultCode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ResultCode, __ReturnBuffer);

					return *(ECreateModelingObjectResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ResultCode, __InBuffer);
				}
			}
		}

		public UObject NewAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewAsset, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewAsset, __InBuffer);
				}
			}
		}

		private static uint __ResultCode = 0;

		private static uint __NewAsset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}