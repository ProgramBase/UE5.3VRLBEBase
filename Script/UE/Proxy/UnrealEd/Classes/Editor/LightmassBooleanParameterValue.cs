using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LightmassBooleanParameterValue")]
	public partial class FLightmassBooleanParameterValue : FLightmassParameterValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.LightmassBooleanParameterValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLightmassBooleanParameterValue()
		{
		}

		public static bool operator ==(FLightmassBooleanParameterValue A, FLightmassBooleanParameterValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLightmassBooleanParameterValue A, FLightmassBooleanParameterValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLightmassBooleanParameterValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool ParameterValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __InBuffer);
				}
			}
		}

		private static uint __ParameterValue = 0;

	}
}