using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectMotionFilterModulationSettings")]
	public partial class FSourceEffectMotionFilterModulationSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SourceEffectMotionFilterModulationSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectMotionFilterModulationSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectMotionFilterModulationSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectMotionFilterModulationSettings A, FSourceEffectMotionFilterModulationSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectMotionFilterModulationSettings A, FSourceEffectMotionFilterModulationSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectMotionFilterModulationSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ESourceEffectMotionFilterModSource ModulationSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModulationSource, __ReturnBuffer);

					return *(ESourceEffectMotionFilterModSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModulationSource, __InBuffer);
				}
			}
		}

		public FVector2D ModulationInputRange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModulationInputRange, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModulationInputRange, __InBuffer);
				}
			}
		}

		public FVector2D ModulationOutputMinimumRange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModulationOutputMinimumRange, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModulationOutputMinimumRange, __InBuffer);
				}
			}
		}

		public FVector2D ModulationOutputMaximumRange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModulationOutputMaximumRange, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModulationOutputMaximumRange, __InBuffer);
				}
			}
		}

		public float UpdateEaseMS
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpdateEaseMS, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpdateEaseMS, __InBuffer);
				}
			}
		}

		private static uint __ModulationSource = 0;

		private static uint __ModulationInputRange = 0;

		private static uint __ModulationOutputMinimumRange = 0;

		private static uint __ModulationOutputMaximumRange = 0;

		private static uint __UpdateEaseMS = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}