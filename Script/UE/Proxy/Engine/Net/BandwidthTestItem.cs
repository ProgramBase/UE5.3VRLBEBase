﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BandwidthTestItem")]
	public partial class FBandwidthTestItem : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BandwidthTestItem");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBandwidthTestItem() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBandwidthTestItem() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBandwidthTestItem A, FBandwidthTestItem B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBandwidthTestItem A, FBandwidthTestItem B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBandwidthTestItem;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<byte> Kilobyte
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Kilobyte, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Kilobyte, __InBuffer);
				}
			}
		}

		private static uint __Kilobyte = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}