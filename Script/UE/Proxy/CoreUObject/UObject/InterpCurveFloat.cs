using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.InterpCurveFloat")]
	public partial class FInterpCurveFloat : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.InterpCurveFloat");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterpCurveFloat() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterpCurveFloat() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterpCurveFloat A, FInterpCurveFloat B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterpCurveFloat A, FInterpCurveFloat B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterpCurveFloat;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FInterpCurvePointFloat> Points
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Points, __ReturnBuffer);

					return *(TArray<FInterpCurvePointFloat>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Points, __InBuffer);
				}
			}
		}

		public bool bIsLooped
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsLooped, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsLooped, __InBuffer);
				}
			}
		}

		public float LoopKeyOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LoopKeyOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LoopKeyOffset, __InBuffer);
				}
			}
		}

		private static uint __Points = 0;

		private static uint __bIsLooped = 0;

		private static uint __LoopKeyOffset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}