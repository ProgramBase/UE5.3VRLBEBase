using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.IntegralCurve")]
	public partial class FIntegralCurve : FIndexedCurve, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.IntegralCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIntegralCurve()
		{
		}

		public static bool operator ==(FIntegralCurve A, FIntegralCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIntegralCurve A, FIntegralCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIntegralCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FIntegralKey> Keys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Keys, __ReturnBuffer);

					return *(TArray<FIntegralKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Keys, __InBuffer);
				}
			}
		}

		public int DefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __InBuffer);
				}
			}
		}

		public bool bUseDefaultValueBeforeFirstKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseDefaultValueBeforeFirstKey, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseDefaultValueBeforeFirstKey, __InBuffer);
				}
			}
		}

		private static uint __Keys = 0;

		private static uint __DefaultValue = 0;

		private static uint __bUseDefaultValueBeforeFirstKey = 0;

	}
}