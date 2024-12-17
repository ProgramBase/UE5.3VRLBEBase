using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.InterpCurvePointFloat")]
	public partial class FInterpCurvePointFloat : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.InterpCurvePointFloat");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterpCurvePointFloat() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterpCurvePointFloat() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterpCurvePointFloat A, FInterpCurvePointFloat B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterpCurvePointFloat A, FInterpCurvePointFloat B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterpCurvePointFloat;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float InVal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InVal, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InVal, __InBuffer);
				}
			}
		}

		public float OutVal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutVal, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutVal, __InBuffer);
				}
			}
		}

		public float ArriveTangent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ArriveTangent, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ArriveTangent, __InBuffer);
				}
			}
		}

		public float LeaveTangent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LeaveTangent, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LeaveTangent, __InBuffer);
				}
			}
		}

		public EInterpCurveMode InterpMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterpMode, __ReturnBuffer);

					return *(EInterpCurveMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterpMode, __InBuffer);
				}
			}
		}

		private static uint __InVal = 0;

		private static uint __OutVal = 0;

		private static uint __ArriveTangent = 0;

		private static uint __LeaveTangent = 0;

		private static uint __InterpMode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}