using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LightmassScalarParameterValue")]
	public partial class FLightmassScalarParameterValue : FLightmassParameterValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.LightmassScalarParameterValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLightmassScalarParameterValue()
		{
		}

		public static bool operator ==(FLightmassScalarParameterValue A, FLightmassScalarParameterValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLightmassScalarParameterValue A, FLightmassScalarParameterValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLightmassScalarParameterValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float ParameterValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __InBuffer);
				}
			}
		}

		private static uint __ParameterValue = 0;

	}
}