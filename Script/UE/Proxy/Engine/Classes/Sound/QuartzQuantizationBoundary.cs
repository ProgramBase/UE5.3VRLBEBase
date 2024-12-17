using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.QuartzQuantizationBoundary")]
	public partial class FQuartzQuantizationBoundary : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.QuartzQuantizationBoundary");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FQuartzQuantizationBoundary() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FQuartzQuantizationBoundary() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FQuartzQuantizationBoundary A, FQuartzQuantizationBoundary B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FQuartzQuantizationBoundary A, FQuartzQuantizationBoundary B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FQuartzQuantizationBoundary;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EQuartzCommandQuantization Quantization
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Quantization, __ReturnBuffer);

					return *(EQuartzCommandQuantization*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Quantization, __InBuffer);
				}
			}
		}

		public float Multiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Multiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Multiplier, __InBuffer);
				}
			}
		}

		public EQuarztQuantizationReference CountingReferencePoint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CountingReferencePoint, __ReturnBuffer);

					return *(EQuarztQuantizationReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CountingReferencePoint, __InBuffer);
				}
			}
		}

		public bool bFireOnClockStart
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFireOnClockStart, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFireOnClockStart, __InBuffer);
				}
			}
		}

		public bool bCancelCommandIfClockIsNotRunning
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCancelCommandIfClockIsNotRunning, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCancelCommandIfClockIsNotRunning, __InBuffer);
				}
			}
		}

		public bool bResetClockOnQueued
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bResetClockOnQueued, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bResetClockOnQueued, __InBuffer);
				}
			}
		}

		public bool bResumeClockOnQueued
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bResumeClockOnQueued, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bResumeClockOnQueued, __InBuffer);
				}
			}
		}

		private static uint __Quantization = 0;

		private static uint __Multiplier = 0;

		private static uint __CountingReferencePoint = 0;

		private static uint __bFireOnClockStart = 0;

		private static uint __bCancelCommandIfClockIsNotRunning = 0;

		private static uint __bResetClockOnQueued = 0;

		private static uint __bResumeClockOnQueued = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}