using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SimpleCurve")]
	public partial class FSimpleCurve : FRealCurve, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SimpleCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSimpleCurve()
		{
		}

		public static bool operator ==(FSimpleCurve A, FSimpleCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSimpleCurve A, FSimpleCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSimpleCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ERichCurveInterpMode InterpMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterpMode, __ReturnBuffer);

					return *(ERichCurveInterpMode*)__ReturnBuffer;
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

		public TArray<FSimpleCurveKey> Keys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Keys, __ReturnBuffer);

					return *(TArray<FSimpleCurveKey>*)__ReturnBuffer;
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

		private static uint __InterpMode = 0;

		private static uint __Keys = 0;

	}
}