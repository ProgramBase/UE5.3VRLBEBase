﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundWaveSpectralDataEntry")]
	public partial class FSoundWaveSpectralDataEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SoundWaveSpectralDataEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundWaveSpectralDataEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSoundWaveSpectralDataEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSoundWaveSpectralDataEntry A, FSoundWaveSpectralDataEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundWaveSpectralDataEntry A, FSoundWaveSpectralDataEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundWaveSpectralDataEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Magnitude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Magnitude, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Magnitude, __InBuffer);
				}
			}
		}

		public float NormalizedMagnitude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NormalizedMagnitude, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NormalizedMagnitude, __InBuffer);
				}
			}
		}

		private static uint __Magnitude = 0;

		private static uint __NormalizedMagnitude = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}