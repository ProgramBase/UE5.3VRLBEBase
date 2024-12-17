using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TimeStretchCurveInstance")]
	public partial class FTimeStretchCurveInstance : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TimeStretchCurveInstance");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTimeStretchCurveInstance() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTimeStretchCurveInstance() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTimeStretchCurveInstance A, FTimeStretchCurveInstance B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTimeStretchCurveInstance A, FTimeStretchCurveInstance B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTimeStretchCurveInstance;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bHasValidData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasValidData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasValidData, __InBuffer);
				}
			}
		}

		private static uint __bHasValidData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}